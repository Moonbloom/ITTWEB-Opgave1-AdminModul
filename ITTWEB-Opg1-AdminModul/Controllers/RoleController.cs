using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
  public class RoleController : Controller
  {
    ApplicationDbContext context = new ApplicationDbContext();
    //
    // GET: /Role/
    public ActionResult Index()
    {
      var list = context.Roles.OrderBy(r => r.Name).ToList().Select(rr => new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
      ViewBag.Roles = list;
      return View();
    }
  }
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext()
      : base("DefaultConnection")
    {
    }
  }
  
}