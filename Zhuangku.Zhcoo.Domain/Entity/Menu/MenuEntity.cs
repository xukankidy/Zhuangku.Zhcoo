using System.Collections.Generic;

namespace Zhuangku.Zhcoo.Domain.Entity.Menu
{
    /// <summary>
    /// 菜单实体类
    /// </summary>
    public class MenuEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 父编号
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 是否为叶节点
        /// </summary>
        public bool IsLeaf { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 是否使用Iframe打开
        /// </summary>
        public bool IsIframe { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 排序编号
        /// </summary>
        public int OrderIndex { get; set; }

        /// <summary>
        /// 子节点列表
        /// </summary>
        public IList<MenuEntity> NodeList { get; set; }

        public MenuEntity()
        {
            NodeList = new List<MenuEntity>();
        }
    }
}