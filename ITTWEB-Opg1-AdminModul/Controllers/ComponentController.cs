using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.DAL;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    public class ComponentController : Controller
    {
        private readonly ComponentManager _componentManager = new ComponentManager();

        public ActionResult Index()
        {
            var testData = _componentManager.GetAllComponents();

            return View(testData);
        }
    }
}