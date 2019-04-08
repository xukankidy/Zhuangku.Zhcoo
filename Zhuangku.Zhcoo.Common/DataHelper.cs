namespace Zhuangku.Zhcoo.Common
{
    /// <summary>
    /// 数据帮助类
    /// </summary>
    public static class DataHelper
    {
        /// <summary>
        /// 整型装换
        /// </summary>
        /// <param name="inputString">待转换的字符串</param>
        /// <returns></returns>
        public static int? GetInt(string inputString)
        {
            int? ret = null;
            if (int.TryParse(inputString, out int temp))
            {
                ret = temp;
            }
            return ret;
        }

        /// <summary>
        /// 整型装换
        /// </summary>
        /// <param name="inputString">待转换的字符串</param>
        /// <param name="defaultValue">转化失败后，返回的默认值</param>
        /// <returns></returns>
        public static int GetInt(string inputString, int defaultValue = 0)
        {
            int ret = defaultValue;
            if (int.TryParse(inputString, out int temp))
            {
                ret = temp;
            }
            return ret;
        }

        public static double GetDouble(string inputString, double defaultValue = 0)
        {
            double ret = defaultValue;
            if (double.TryParse(inputString, out double temp))
            {
                ret = temp;
            }
            return ret;
        }

        public static decimal GetDecimal(string inputString, decimal defaultValue = 0)
        {
            decimal ret = defaultValue;
            if (decimal.TryParse(inputString, out decimal temp))
            {
                ret = temp;
            }
            return ret;
        }

        public static float GetFloat(string inputString, float defaultValue = 0)
        {
            float ret = defaultValue;
            if (float.TryParse(inputString, out float temp))
            {
                ret = temp;
            }
            return ret;
        }

        public static bool GetBoolen(string inputString, bool defaultValue = false)
        {
            bool ret = defaultValue;
            if (bool.TryParse(inputString, out bool temp))
            {
                ret = temp;
            }
            return ret;
        }
    }
}