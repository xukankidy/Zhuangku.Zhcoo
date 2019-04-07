using System.Collections.Generic;
using System.Web.Mvc;
using Zhuangku.Zhcoo.Domain.Entity;
using Zhuangku.Zhcoo.Domain.Entity.Menu;

namespace Zhuangku.Zhcoo.Backend.Controllers
{
    /// <summary>
    /// 主菜单控制器
    /// </summary>
    public class MainMenuController : BaseController
    {
        public JsonResult GetList()
        {
            var rets = new ResultEntity<MenuEntity>();

            #region 拼装对象

            var list = new List<MenuEntity>();
            var folder1 = new MenuEntity
            {
                Id = "1",
                Code = "zhuangxiubankuai",
                ParentId = "0",
                Title = "装修板块",
                Icon = "folder",
                IsLeaf = false,
                IsEnabled = true
            };
            var folder2 = new MenuEntity
            {
                Id = "2",
                Code = "zhaobiaotongji",
                ParentId = "0",
                Title = "招标统计",
                Icon = "folder",
                IsLeaf = false,
                IsEnabled = true
            };
            var folder3 = new MenuEntity
            {
                Id = "3",
                Code = "Demo",
                ParentId = "0",
                Title = "DEMO",
                Icon = "folder",
                IsLeaf = false,
                IsEnabled = true
            };
            var item1 = new MenuEntity
            {
                Id = "3",
                Code = "zaijiangongdi",
                ParentId = "1",
                Title = "在建工地",
                Icon = "list",
                IsLeaf = true,
                IsIframe = true,
                Url = "/Building/Index/",
                IsEnabled = true
            };
            var item2 = new MenuEntity
            {
                Id = "4",
                Code = "zhuangshizhaobaioguanli",
                ParentId = "1",
                Title = "装饰招标管理",
                Icon = "list",
                IsLeaf = true,
                IsIframe = true,
                Url = "/Building/Manager/",
                IsEnabled = true
            };
            var item3 = new MenuEntity
            {
                Id = "5",
                Code = "huiyuantongji",
                ParentId = "2",
                Title = "会员统计",
                Icon = "list",
                IsLeaf = true,
                IsIframe = true,
                Url = "/Tongji/Index/",
                IsEnabled = true
            };
            var item4 = new MenuEntity
            {
                Id = "6",
                Code = "kefutongij",
                ParentId = "2",
                Title = "客服统计",
                Icon = "list",
                IsLeaf = true,
                IsIframe = true,
                Url = "/Tongji/kefu/",
                IsEnabled = true
            };
            var item5 = new MenuEntity
            {
                Id = "5",
                Code = "tishikongjian",
                ParentId = "3",
                Title = "提示控件",
                Icon = "list",
                IsLeaf = true,
                IsIframe = false,
                Url = "/Test/Notice/",
                IsEnabled = true
            };
            folder1.NodeList.Add(item1);
            folder1.NodeList.Add(item2);
            folder2.NodeList.Add(item3);
            folder2.NodeList.Add(item4);
            folder3.NodeList.Add(item5);
            rets.Datas.Add(folder1);
            rets.Datas.Add(folder2);
            rets.Datas.Add(folder3);

            #endregion 拼装对象

            rets.IsSuccess = true;
            return Json(rets);
        }
    }
}