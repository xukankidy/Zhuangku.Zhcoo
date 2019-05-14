using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Zhuangku.DevTool.EFBuilder.Engine;

namespace Zhuangku.DevTool.EFBuilder
{
    public partial class FormMain : Form
    {
        private IEngine _databaseEngine;
        private DataTable _dtSource;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var sqlType = ConfigurationManager.AppSettings["SqlType"];
            _databaseEngine = DatabaseEngine.CreateInstance(sqlType);
            if (_databaseEngine == null)
            {
                return;
            }
            _dtSource = _databaseEngine.GetTableLsit();
            dataGridViewTable.DataSource = _dtSource;
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            if (_dtSource == null)
            {
                return;
            }
            foreach (DataRow dr in _dtSource.Rows)
            {
                if (dr["checked"].ToString().ToLower() == "true")
                {
                    dr["checked"] = false;
                }
                else
                {
                    dr["checked"] = true;
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (_dtSource == null)
            {
                return;
            }

            var tables = new List<string>();
            var fields = new Dictionary<string, List<FieldModel>>();

            #region 确认保存路径

            var outputDir = ParameterConfig.OUTPUTDIR;
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            #endregion 确认保存路径

            foreach (DataRow dr in _dtSource.Rows)
            {
                var isChecked = dr["checked"].ToString().ToLower() == "true" ? true : false;
                if (!isChecked)
                {//没有勾选，继续循环
                    continue;
                }
                var tablename = dr["name"].ToString();
                var commentTable = _databaseEngine.GetCommentList("table", tablename);
                var sb = new StringBuilder();
                sb.AppendLine(ParameterConfig.TABLEUSINGREGION);
                sb.AppendLine("namespace " + ParameterConfig.NAMESPACE);
                sb.AppendLine("{");
                if (!string.IsNullOrWhiteSpace(commentTable))
                {//添加备注
                    sb.AppendLine(commentTable);
                }
                sb.AppendLine(_databaseEngine.GetTabLevel(1) + "public partial class " + tablename);
                sb.AppendLine(_databaseEngine.GetTabLevel(1) + "{");

                #region 生成属性

                var fieldList = _databaseEngine.GetFieldList(tablename);

                foreach (var item in fieldList)
                {
                    if (!string.IsNullOrWhiteSpace(item.FieldComment))
                    {
                        sb.AppendLine(item.FieldComment);
                    }
                    sb.AppendLine(_databaseEngine.GetTabLevel(2) + item.FieldAccessType + " " + item.FieldType + (item.IsNullable ? (item.FieldType.ToLower() == "string" ? "" : "?") : "") + " " + item.FieldName + "  { get; set; }" + Environment.NewLine);
                }
                fields.Add(tablename, fieldList);

                #endregion 生成属性

                sb.AppendLine(_databaseEngine.GetTabLevel(1) + "}");
                sb.AppendLine("}");
                File.WriteAllLines(outputDir + tablename + ".cs", new string[] { sb.ToString() });

                tables.Add(dr["name"].ToString());
            }

            #region 生成context文件

            var sbContext = new StringBuilder();
            var contextFilename = ParameterConfig.CONTEXTFILENAME + "Context";
            sbContext.Append(ParameterConfig.CONTEXTUSINGREGION);
            sbContext.AppendLine("namespace " + ParameterConfig.NAMESPACE);
            sbContext.AppendLine("{");
            sbContext.AppendLine(_databaseEngine.GetTabLevel(1) + "public partial class " + contextFilename + " : DbContext");
            sbContext.AppendLine(_databaseEngine.GetTabLevel(1) + "{");

            #region 构造方法

            sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "#region 构造方法 " + Environment.NewLine);
            sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "public ZhuangkuIDSContext(){}" + Environment.NewLine);
            sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "#endregion 构造方法" + Environment.NewLine);

            #endregion 构造方法

            #region 虚表定义

            sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "#region 虚表定义 " + Environment.NewLine);
            foreach (var item in tables)
            {
                sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "public virtual DbSet<" + item + "> " + item + " { get; set; }");
            }
            sbContext.AppendLine(Environment.NewLine + _databaseEngine.GetTabLevel(2) + "#endregion 虚表定义" + Environment.NewLine);

            #endregion 虚表定义

            #region 生成模型

            sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "#region 生成模型 " + Environment.NewLine);
            sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "protected override void OnModelCreating(ModelBuilder modelBuilder)");
            sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "{");

            foreach (var item in tables)
            {
                sbContext.AppendLine(_databaseEngine.GetTabLevel(3) + "modelBuilder.Entity<" + item + ">(entity =>");
                sbContext.AppendLine(_databaseEngine.GetTabLevel(3) + "{");

                #region 映射表名

                sbContext.AppendLine(_databaseEngine.GetTabLevel(4) + "entity.ToTable(\"" + item + "\");");

                #endregion 映射表名

                sbContext.AppendLine(_databaseEngine.GetTabLevel(3) + "}" + Environment.NewLine);
            }
            sbContext.AppendLine(_databaseEngine.GetTabLevel(2) + "}");
            sbContext.AppendLine(Environment.NewLine + _databaseEngine.GetTabLevel(2) + "#endregion 生成模型" + Environment.NewLine);

            #endregion 生成模型

            sbContext.AppendLine(_databaseEngine.GetTabLevel(1) + "}");
            sbContext.AppendLine("}");
            File.WriteAllLines(outputDir + contextFilename + ".cs", new string[] { sbContext.ToString() });

            #endregion 生成context文件

            MessageBox.Show("生成完成");
        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                var isChecked = dataGridViewTable.Rows[e.RowIndex].Cells["ColumnCheked"].Value.ToString().ToLower() == "true" ? false : true;
                var name = dataGridViewTable.Rows[e.RowIndex].Cells["name"].Value.ToString();
                var dr = _dtSource.Select("name='" + name + "'")[0];
                dr["checked"] = isChecked;
            }
        }
    }
}