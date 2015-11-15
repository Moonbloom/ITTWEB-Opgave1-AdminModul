using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.Models;
using Microsoft.Ajax.Utilities;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
  public class ComponentController : Controller
  {

    //
    // GET: /Component/
    public ActionResult Index()
    {
      var testData = new List<Component>();
      var com1 = new Component()
      {
        AdminComment = "admin comment",
        ComponentNumber = 1337,
        ComponentType = new ComponentType(){ComponentName = "namename"},
        Id = 1,
        LoanInformation = null,
        SerieNr = "1337",
        UserComment = "this product sux"
      };
      var com2 = new Component()
      {
        AdminComment = "admin comment2",
        ComponentNumber = 1338,
        ComponentType = new ComponentType(){LocalImageUrl = "http://dreamatico.com/data_images/kitten/kitten-1.jpg",ComponentName = "Kat"},
        Id = 2,
        LoanInformation = null,
        SerieNr = "1338",
        UserComment = "this product sux also"
      };
      var com3 = new Component()
      {
        AdminComment = "admin comment3",
        ComponentNumber = 1339,
        ComponentType = new ComponentType() {ComponentName = "Kat" },
        Id = 3,
        LoanInformation = null,
        SerieNr = "1339",
        UserComment = "this product sux also 1 "
      };
      testData.Add(com1);
      testData.Add(com2);
      testData.Add(com3);
      return View(testData);
    }
  }
}