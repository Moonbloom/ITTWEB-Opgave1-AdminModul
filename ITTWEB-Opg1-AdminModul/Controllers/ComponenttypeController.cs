﻿using System.Collections.Generic;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.Models;
using Microsoft.Owin.Security.Google;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
  public class ComponenttypeController : Controller
  {

    public ActionResult Index()
    {
      var testData = new List<ComponentType>();
      var com1 = new ComponentType()
      {
        Category = new Category() { CategoryName = "Dyr"},
        CategoryId = 1,
        ComponentInfo = "this is cat",
        Datasheet = "https://www.google.dk/", 
        ComponentName = "kat",
        ComponentId = 1337,
        LocalImageUrl = "https://pbs.twimg.com/profile_images/562466745340817408/_nIu8KHX.jpeg",
        ManufacturerLink = "https://www.google.dk/",
      };

      testData.Add(com1);
      return View(testData);
    }
  }
}