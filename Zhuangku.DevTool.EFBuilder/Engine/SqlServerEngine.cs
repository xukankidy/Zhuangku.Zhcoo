using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Zhuangku.DevTool.EFBuilder.Engine
{
    public class SqlServerEngine : IEngine
    {
        #region 私有成员

        private readonly string _connectionString;

        #endregion 私有成员

        #region 构造方法

        public SqlServerEngine()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SqlServer"].ToString();
        }

        #endregion 构造方法

        /// <summary>
        /// 获取指定类型的备注信息
        /// </summary>
        /// <param name="commentType">备注类型：table，field</param>
        /// <param name="typename">类型名称：表名或者字段名</param>
        /// <param name="tablename">表名，备注类型为字段时使用</param>
        /// <param name="tabLevel">缩进等级</param>
        /// <returns></returns>
        public string GetCommentList(string commentType, string typename, string tablename = "", int tabLevel = 1)
        {
            var ret = string.Empty;

            if (commentType.ToLower() == "table")
            {
                var sqlString = "SELECT * FROM fn_listextendedproperty (NULL, 'schema', 'dbo', 'table', default, NULL, NULL) WHERE objname = '" + typename + "'";
                var tableInDb = Query(sqlString, _connectionString);
                if (tableInDb.Rows.Count == 0)
                {
                    return ret;
                }
                var comment = tableInDb.Rows[0]["value"].ToString();
                if (!string.IsNullOrWhiteSpace(comment))
                {
                    ret += GetTabLevel(tabLevel) + "/// <summary>" + System.Environment.NewLine;
                    var commentArray = comment.Split(new string[] { "\r", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int k = 0; k < commentArray.Length; k++)
                    {
                        ret += GetTabLevel(tabLevel) + "/// " + commentArray[k].Trim() + System.Environment.NewLine;
                    }
                    ret += GetTabLevel(tabLevel) + "/// <summary>";
                }
            }
            else if (commentType.ToLower() == "field")
            {
                var sqlString = "SELECT * FROM fn_listextendedproperty (NULL, 'user', 'dbo', 'table','" + tablename + "', 'column', NULL) WHERE objname = '" + typename + "'";
                var tableInDb = Query(sqlString, _connectionString);
                if (tableInDb.Rows.Count == 0)
                {
                    return ret;
                }
                var comment = tableInDb.Rows[0]["value"].ToString();
                if (!string.IsNullOrWhiteSpace(comment))
                {
                    ret += GetTabLevel(tabLevel) + "/// <summary>" + System.Environment.NewLine;
                    var commentArray = comment.Split(new string[] { "\r", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int k = 0; k < commentArray.Length; k++)
                    {
                        ret += GetTabLevel(tabLevel) + "/// " + commentArray[k].Trim() + System.Environment.NewLine;
                    }
                    ret += GetTabLevel(tabLevel) + "/// <summary>";
                }
            }
            return ret;
        }

        /// <summary>
        /// 获取对应数据表的字段列表数据
        /// </summary>
        /// <param name="tablename">表名</param>
        /// <returns></returns>
        public List<FieldModel> GetFieldList(string tablename)
        {
            var rets = new List<FieldModel>();
            var sqlString = "SELECT syscolumns.name as keyname,systypes.name as keyproperty,syscolumns.isnullable,syscolumns.length FROM syscolumns, systypes WHERE syscolumns.xusertype = systypes.xusertype AND syscolumns.id = object_id('" + tablename + "')";
            var tableInDb = Query(sqlString, _connectionString);

            for (int i = 0; i < tableInDb.Rows.Count; i++)
            {
                var field = new FieldModel
                {
                    FieldAccessType = "public",
                    FieldName = tableInDb.Rows[i]["keyname"].ToString(),
                    FieldType = tableInDb.Rows[i]["keyproperty"].ToString(),
                    FieldLength = int.Parse(tableInDb.Rows[i]["length"].ToString()),
                    IsNullable = tableInDb.Rows[i]["isnullable"].ToString() == "0" ? false : true,
                    FieldComment = GetCommentList("field", tableInDb.Rows[i]["keyname"].ToString(), tablename, 2)
                };
                rets.Add(field);

                switch (field.FieldType.Trim().ToLower())
                {
                    case "smallint":
                        field.FieldType = "short";
                        break;

                    case "int":
                        field.FieldType = "int";
                        break;

                    case "bigint":
                        field.FieldType = "long";
                        break;

                    case "real":
                        field.FieldType = "float";
                        break;

                    case "float":
                        field.FieldType = "double";
                        break;

                    case "money":
                        field.FieldType = "decimal";
                        break;

                    case "datetime":
                        field.FieldType = "DateTime";
                        break;

                    case "uniqueidentifier":
                        field.FieldType = "Guid";
                        break;

                    case "bit":
                        field.FieldType = "bool";
                        break;

                    case "tinyint":
                        field.FieldType = "byte";
                        break;

                    case "image":
                        field.FieldType = "byte[]";
                        break;

                    case "binary":
                        field.FieldType = "byte[]";
                        break;

                    default:
                        field.FieldType = "string";
                        break;
                }
            }

            return rets;
        }

        /// <summary>
        /// 获取数据表列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetTableLsit()
        {
            var sqlString = "SELECT * FROM sys.sysobjects WHERE TYPE='U' ORDER BY name";
            var tableInDb = Query(sqlString, _connectionString);
            var tableOut = new DataTable();
            tableOut.Columns.Add("id");
            tableOut.Columns.Add("name");
            tableOut.Columns.Add("checked");
            for (int i = 0; i < tableInDb.Rows.Count; i++)
            {
                var dr = tableOut.NewRow();
                dr["id"] = tableInDb.Rows[i]["id"].ToString();
                dr["name"] = tableInDb.Rows[i]["name"].ToString();
                dr["checked"] = true;
                tableOut.Rows.Add(dr);
            }
            return tableOut;
        }

        /// <summary>
        /// 获取缩进等级对应的缩进量
        /// </summary>
        /// <param name="tabLevel">缩进等级</param>
        /// <returns></returns>
        public string GetTabLevel(int tabLevel)
        {
            var ret = string.Empty;

            for (int i = 0; i < tabLevel; i++)
            {
                ret += "    ";
            }

            return ret;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sqlString">查询字符串</param>
        /// <param name="connectionString">数据库连接字符创</param>
        /// <returns></returns>
        public DataTable Query(string sqlString, string connectionString)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(sqlString, connection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return ds.Tables[0];
            }
        }
    }
}