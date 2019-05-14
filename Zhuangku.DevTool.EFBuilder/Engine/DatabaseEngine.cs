using System;

namespace Zhuangku.DevTool.EFBuilder.Engine
{
    /// <summary>
    /// 数据库引擎
    /// 用于根据类型名称生成相应的引擎实例
    /// </summary>
    public class DatabaseEngine
    {
        /// <summary>
        /// 生成实例
        /// </summary>
        /// <param name="sqlType">数据库类型</param>
        /// <returns></returns>
        public static IEngine CreateInstance(string sqlType)
        {
            var type = Type.GetType("Zhuangku.DevTool.EFBuilder.Engine." + sqlType);
            var obj = Activator.CreateInstance(type, true);
            return obj as IEngine;
        }
    }
}