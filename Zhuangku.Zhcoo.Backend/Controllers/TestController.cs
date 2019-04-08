using System.Threading;
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
            Thread.Sleep(9999999);
            return View();
        }
    }
}