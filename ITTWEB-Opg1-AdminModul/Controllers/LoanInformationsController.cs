using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.DAL;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LoanInformationsController : Controller
    {
        private readonly EsDbManager _esDbManager = new EsDbManager();

        // GET: LoanInformations
        public ActionResult Index()
        {
            var loanInformations = _esDbManager.GetAllLoanInformation();
            return View(loanInformations.ToList());
        }

        // GET: LoanInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var loanInformation = _esDbManager.GetLoanInformation(id);
            if (loanInformation == null)
            {
                return HttpNotFound();
            }
            return View(loanInformation);
        }

        // GET: LoanInformations/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(_esDbManager.GetStudents(), "Id", "MobilNo");
            return View();
        }

        // POST: LoanInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id,LoanDate,ReturnDate,IsEmailSend,IsReservation,ReservationDate,StudentId")] LoanInformation loanInformation)
        {
            if (ModelState.IsValid)
            {
                _esDbManager.CreateLoanInformation(loanInformation);
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(_esDbManager.GetStudents(), "Id", "MobilNo", loanInformation.StudentId);
            return View(loanInformation);
        }

        // GET: LoanInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var loanInformation = _esDbManager.GetLoanInformation(id);
            if (loanInformation == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(_esDbManager.GetStudents(), "Id", "MobilNo", loanInformation.StudentId);
            return View(loanInformation);
        }

        // POST: LoanInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "Id,LoanDate,ReturnDate,IsEmailSend,IsReservation,ReservationDate,StudentId")] LoanInformation loanInformation)
        {
            if (ModelState.IsValid)
            {
                _esDbManager.UpdateLoanInformation(loanInformation);
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(_esDbManager.GetStudents(), "Id", "MobilNo", loanInformation.StudentId);
            return View(loanInformation);
        }

        // GET: LoanInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var loanInformation = _esDbManager.GetLoanInformation(id);
            if (loanInformation == null)
            {
                return HttpNotFound();
            }
            return View(loanInformation);
        }

        // POST: LoanInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _esDbManager.DeleteLoanInformation(id);
            return RedirectToAction("Index");
        }
    }
}