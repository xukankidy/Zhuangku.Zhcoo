using System.Web.Mvc;

namespace Zhuangku.Zhcoo.Backend.Controllers
{
    /// <summary>
    /// 登陆控制器
    /// </summary>
    public class LoginController : BaseController
    {
        /// <summary>
        /// 登陆主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}