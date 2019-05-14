namespace Zhuangku.DevTool.EFBuilder.Engine
{
    public class TableModel
    {
        /// <summary>
        /// 表格编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 表格名称
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 表格备注文本
        /// </summary>
        public string TableComment { get; set; }
    }
}