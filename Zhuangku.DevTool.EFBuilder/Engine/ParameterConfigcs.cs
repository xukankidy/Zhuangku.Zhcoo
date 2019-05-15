using System.Configuration;

namespace Zhuangku.DevTool.EFBuilder.Engine
{
    /// <summary>
    /// 参数配置类
    /// </summary>
    public static class ParameterConfig
    {
        static ParameterConfig()
        {
            TABLEUSINGREGION = ConfigurationManager.AppSettings["UsingRegion"].ToString();
            NAMESPACE = ConfigurationManager.AppSettings["Namespace"].ToString();
            OUTPUTDIR = ConfigurationManager.AppSettings["OutputDir"].ToString();
            //SPACECOUNT = ConfigurationManager.AppSettings["SpaceCount"].ToString();
            CONTEXTUSINGREGION = ConfigurationManager.AppSettings["ContextUsingRegion"].ToString();
            CONTEXTFILENAME = ConfigurationManager.AppSettings["ContextFilename"].ToString();
            OUTPUTDIRDTO = ConfigurationManager.AppSettings["OutputDirDto"].ToString();
        }

        /// <summary>
        /// 表需要使用的Using
        /// </summary>
        public readonly static string TABLEUSINGREGION;

        /// <summary>
        /// 命名空间
        /// </summary>
        public readonly static string NAMESPACE;

        /// <summary>
        /// 输出路径
        /// </summary>
        public readonly static string OUTPUTDIR;

        /// <summary>
        /// 上下文需要使用的Using
        /// </summary>
        public readonly static string CONTEXTUSINGREGION;

        /// <summary>
        /// 生成的上下文文件的名称
        /// </summary>
        public readonly static string CONTEXTFILENAME;

        /// <summary>
        /// DOT输出路径
        /// </summary>
        public readonly static string OUTPUTDIRDTO;
    }
}