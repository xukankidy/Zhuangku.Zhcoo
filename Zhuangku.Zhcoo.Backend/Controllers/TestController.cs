using System.Web.Mvc;

namespace Zhuangku.Zhcoo.Backend.Controllers
{
    public class TestController : BaseController
    {
        /// <summary>
        /// 提醒控件
        /// </summary>
        /// <returns></returns>
        public ActionResult Notice()
        {
            return View();
        }

        public ActionResult Modal()
        {
            return View();
        }
    }
}