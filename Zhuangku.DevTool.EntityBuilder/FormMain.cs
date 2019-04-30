using Dakuan.AjaxZipper.CommonLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Zhuangku.DevTool.EntityBuilder.Model;

namespace Zhuangku.DevTool.EntityBuilder
{
    public partial class FormMain : Form
    {

        private List<FieldModel> _fieldModelList = new List<FieldModel>();
        private DataTable _dtOld = new DataTable("FieldModelListOld");
        private DataTable _dtNew = new DataTable("FieldModelListNew");


        public FormMain()
        {
            InitializeComponent();
            comboBoxAccessTpye.SelectedIndex = 0;
            comboBoxDataType.SelectedIndex = 0;
            comboBoxClassAcessType.SelectedIndex = 0;

            ListOld.ValueMember = "FieldName";
            ListOld.DisplayMember = "ShowText";
            ListOld.CheckOnClick = true;
            _dtOld.Columns.Add("FieldName");
            _dtOld.Columns.Add("DataType");
            _dtOld.Columns.Add("AccessType");
            _dtOld.Columns.Add("Comment");
            _dtOld.Columns.Add("AllowNulll");
            _dtOld.Columns.Add("ShowText");

            ListNew.ValueMember = "FieldName";
            ListNew.DisplayMember = "ShowText";
            ListNew.CheckOnClick = true;
            _dtNew.Columns.Add("FieldName");
            _dtNew.Columns.Add("DataType");
            _dtNew.Columns.Add("AccessType");
            _dtNew.Columns.Add("Comment");
            _dtNew.Columns.Add("AllowNulll");
            _dtNew.Columns.Add("ShowText");
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            var accessType = comboBoxAccessTpye.Text;
            var dataType = comboBoxDataType.Text;
            var allowNull = CheckBoxAllowNull.Checked;
            var fieldName = textBoxFieldName.Text;
            var comment = richTextBoxComment.Text;

            if (string.IsNullOrWhiteSpace(fieldName))
            {
                MessageBox.Show("必须填写成员名称");
                textBoxFieldName.Focus();
                return;
            }
            fieldName = fieldName.Trim();
            var theSameModel = _fieldModelList.Find(i => i.FieldName == fieldName);
            if (theSameModel != null)
            {
                MessageBox.Show("存在【" + theSameModel.FieldName + "】字段");
                textBoxFieldName.Select();
                return;
            }
            var model = new FieldModel
            {
                AccessType = accessType,
                DataType = dataType,
                AllowNulll = allowNull,
                FieldName = fieldName,
                Comment = comment
            };
            _fieldModelList.Add(model);
            var dr = _dtNew.NewRow();
            dr["AccessType"] = accessType;
            dr["DataType"] = dataType;
            dr["AllowNulll"] = allowNull;
            dr["FieldName"] = fieldName;
            dr["Comment"] = comment;
            dr["ShowText"] = accessType + " " + dataType + CheckAllowNull(dataType, allowNull) + " " + fieldName;
            _dtNew.Rows.Add(dr);
            ListNew.DataSource = _dtNew;
        }

        private string CheckAllowNull(string dataType, bool allowNull)
        {
            var ret = string.Empty;
            if (string.IsNullOrWhiteSpace(dataType) || !allowNull)
            {
                return ret;
            }
            dataType = dataType.Trim().ToLower();
            if (dataType == "int" ||
                dataType == "float" ||
                dataType == "double" ||
                dataType == "decimal" ||
                dataType == "bool" ||
                dataType == "datatime" ||
                dataType == "byte" ||
                dataType == "short")
            {
                ret = "?";
            }
            return ret;
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            if (ListOld.CheckedItems.Count == 0)
            {
                return;
            }

            foreach (var item in ListOld.CheckedItems)
            {
                AddNewItem(item);
            }
        }

        private void AddNewItem(object item)
        {
            if (item == null)
            {
                return;
            }
            var drv = item as DataRowView;
            if (drv == null)
            {
                return;
            }

            if (IsContainField(drv))
            {
                MessageBox.Show("已包含成员：" + drv.Row["FieldName"]);
                return;
            }

            var drvAdd = _dtNew.NewRow();

            var accessType = drv.Row["AccessType"].ToString();
            var dataType = drv.Row["DataType"].ToString();
            var allowNull = drv.Row["AllowNulll"].ToString();
            var fieldName = drv.Row["FieldName"].ToString();
            var comment = drv.Row["Comment"].ToString();

            drvAdd["AccessType"] = accessType;
            drvAdd["DataType"] = dataType;
            drvAdd["AllowNulll"] = allowNull;
            drvAdd["FieldName"] = fieldName;
            drvAdd["Comment"] = comment;
            drvAdd["ShowText"] = accessType + " " + dataType + CheckAllowNull(dataType, allowNull.ToLower() == "true" ? true : false) + " " + fieldName;
            _dtNew.Rows.Add(drvAdd);
            ListNew.DataSource = _dtNew;
        }

        private bool IsContainField(DataRowView drv)
        {
            if (_dtNew.Rows.Count == 0)
            {
                return false;
            }
            foreach (var item in _dtNew.Rows)
            {
                var drNew = item as DataRow;
                if (drv.Row["FieldName"].ToString().Trim() == drNew["FieldName"].ToString().Trim())
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ListNew.CheckedItems.Count == 0)
            {
                MessageBox.Show("没有选中导出成员");
                return;
            }
            var sb = new StringBuilder();

            GenerateModel(sb, ListNew.CheckedItems);

            File.AppendAllText("e:\\model.cs", sb.ToString());
            MessageBox.Show("生成完成");
        }

        private void GenerateModel(StringBuilder sb, CheckedListBox.CheckedItemCollection checkedItems)
        {
            var className = textBoxClassName.Text;
            var classAccessType = comboBoxClassAcessType.Text;
            var isPartial = checkBoxIsPartial.Checked;
            var isSerial = checkBoxIsSerial.Checked;
            var classUsing = richTextBoxUsing.Text;
            var classComment = richTextBoxClassComment.Text;
            var nameSpace = textBoxNameSpace.Text;

            if (!string.IsNullOrWhiteSpace(classUsing))
            {
                sb.Append(classUsing.Trim() + "\r\n\r\n");
            }
            sb.Append("namespace " + nameSpace.Trim() + "\r\n{\r\n");

            if (!string.IsNullOrWhiteSpace(classComment))
            {
                var commentList = classComment.Split(new string[] { "\n" }, StringSplitOptions.None);
                sb.Append("    /// <summary>\r\n");
                for (int i = 0; i < commentList.Length; i++)
                {
                    sb.Append("    /// " + commentList[i].Trim() + "\r\n");
                }
                sb.Append("    /// <summary>\r\n");
            }

            if (isSerial)
            {
                sb.Append("    [Serializable]\r\n");
            }

            sb.Append("    " + classAccessType + " " + (isPartial ? "partial" : "") + " class " + className + "\r\n");
            sb.Append("    {\r\n");

            foreach (var item in checkedItems)
            {
                var drv = item as DataRowView;

                var accessType = drv.Row["AccessType"].ToString();
                var dataType = drv.Row["DataType"].ToString();
                var allowNull = drv.Row["AllowNulll"].ToString();
                var fieldName = drv.Row["FieldName"].ToString();
                var comment = drv.Row["Comment"].ToString();

                if (!string.IsNullOrWhiteSpace(comment))
                {
                    var commentList = comment.Split(new string[] { "\n" }, StringSplitOptions.None);
                    sb.Append("        /// <summary>\r\n");
                    for (int i = 0; i < commentList.Length; i++)
                    {
                        sb.Append("        /// " + commentList[i].Trim() + "\r\n");
                    }
                    sb.Append("        /// <summary>\r\n");
                }
                sb.Append("        " + accessType + " " + dataType + CheckAllowNull(dataType, allowNull.ToLower() == "true" ? true : false) + " " + fieldName + " { get; set; }\r\n\r\n");
            }
            sb.Append("    }\r\n}");
        }

        private void ListOld_DragDrop(object sender, DragEventArgs e)
        {

            string filePath = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            try
            {
                var txt = IoUtility.GetFileText(filePath);
                if (string.IsNullOrWhiteSpace(txt))
                {
                    MessageBox.Show("该文件没有内容");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
            }

        }

        private void ListOld_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}