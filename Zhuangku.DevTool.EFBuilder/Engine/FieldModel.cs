namespace Zhuangku.DevTool.EFBuilder.Engine
{
    /// <summary>
    /// 字段模型
    /// </summary>
    public class FieldModel
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// 字段访问类型
        /// public, private, protected
        /// </summary>
        public string FieldAccessType { get; set; }

        /// <summary>
        /// 字段数据类型
        /// int,string,bool等
        /// </summary>
        public string FieldType { get; set; }

        /// <summary>
        /// 字段备注
        /// </summary>
        public string FieldComment { get; set; }

        /// <summary>
        /// 字段数据长度
        /// </summary>
        public int FieldLength { get; set; }

        /// <summary>
        /// 字段可否为空值
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// 字段是否为Unicode
        /// </summary>
        public bool IsUnicode { get; set; }
    }
}