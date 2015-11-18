using System.Web.Mvc;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}