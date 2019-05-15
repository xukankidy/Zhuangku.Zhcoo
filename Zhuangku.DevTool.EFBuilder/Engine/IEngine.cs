using System.Collections.Generic;
using System.Data;

namespace Zhuangku.DevTool.EFBuilder.Engine
{
    public interface IEngine
    {
        /// <summary>
        /// 获取数据表列表
        /// </summary>
        /// <returns></returns>
        DataTable GetTableLsit();

        /// <summary>
        /// 获取对应数据表的字段列表数据
        /// </summary>
        /// <param name="tablename">表名</param>
        /// <returns></returns>
        List<FieldModel> GetFieldList(string tablename);

        /// <summary>
        /// 获取指定类型的备注信息
        /// </summary>
        /// <param name="commentType">备注类型：table，field</param>
        /// <param name="typename">类型名称：表名或者字段名</param>
        /// <param name="tablename">表名，备注类型为字段时使用</param>
        /// <param name="tabLevel">缩进等级</param>
        /// <returns></returns>
        string GetCommentList(string commentType, string typename, string tablename = "", int tabLevel = 1);

        /// <summary>
        /// 获取缩进等级对应的缩进量
        /// </summary>
        /// <param name="tabLevel">缩进等级</param>
        /// <returns></returns>
        string GetTabLevel(int tabLevel);

        /// <summary>
        /// 获取表的主键
        /// </summary>
        /// <param name="tablename">表名</param>
        /// <returns></returns>
        FieldModel GetKeyField(string tablename);
    }
}