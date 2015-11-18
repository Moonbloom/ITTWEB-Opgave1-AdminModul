using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AddAdminUsers();
            return View();
        }

        private void AddAdminUsers()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            using (var context = new ApplicationDbContext())
            {
                var cso = context.Users.FirstOrDefault(w => w.UserName == "chr.sorensen1990@gmail.com");
                if (cso != null) userManager.AddToRole(cso.Id, "Admin");

                var khl = context.Users.FirstOrDefault(w => w.UserName == "kasperliholm@hotmail.com");
                if (khl != null) userManager.AddToRole(khl.Id, "Admin");
            }
        }
    }
}