using System.Web.Mvc;

namespace Zhuangku.Zhcoo.Backend.Controllers
{
    /// <summary>
    /// 框架控制器
    /// </summary>
    public class FrameworkController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}