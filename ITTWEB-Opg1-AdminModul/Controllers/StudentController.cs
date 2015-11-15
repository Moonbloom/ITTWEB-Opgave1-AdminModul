using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
  public class StudentController : Controller
  {
    public ActionResult Index()
    {
      var testData = new Student()
      {
        Email = "Nope@nopemail.com",
        MobilNo = "666",
        StudentName = "Poul",
        StudentId = "1",
      };
      return View(testData);
    }
  }
}