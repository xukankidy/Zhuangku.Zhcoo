using System;
using System.Collections.Generic;

namespace Zhuangku.Zhcoo.Domain.Entity
{
    /// <summary>
    /// 结果实体类
    /// </summary>
    public class ResultEntity
    {
        public ResultEntity()
        {
            CDate = DateTime.Now;
        }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 操作码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 操作时间戳
        /// </summary>
        public DateTime CDate { get; set; }
    }

    /// <summary>
    /// 结果泛型实体类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultEntity<T> : ResultEntity
    {
        /// <summary>
        /// 返回的数据集合
        /// </summary>
        public IList<T> Datas { get; set; }

        public ResultEntity()
        {
            Datas = new List<T>();
        }
    }
}