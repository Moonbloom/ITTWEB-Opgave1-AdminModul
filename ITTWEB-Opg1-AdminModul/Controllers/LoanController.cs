using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    public class LoanController : Controller
    {
        public ActionResult Index()
        {
            var testData = new List<LoanInformation>();
            testData.Add(new LoanInformation()
            {
                Id = 1,
                IsEmailSend = false,
                IsReservation = false,
                LoanDate = new DateTime(2015, 11, 15),
                ReservationDate = new DateTime(2015, 11, 10),
                ReturnDate = new DateTime(2016, 11, 11),
                Student = new Student() { StudentName = "Poul" }
            });
            return View(testData);
        }
    }
}