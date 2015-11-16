using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    public class LoanInformationsController : Controller
    {
        private readonly EsDbContext _db = new EsDbContext();

        // GET: LoanInformations
        public ActionResult Index()
        {
            var loanInformations = _db.LoanInformations.Include(l => l.Student);
            return View(loanInformations.ToList());
        }

        // GET: LoanInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var loanInformation = _db.LoanInformations.Find(id);
            if (loanInformation == null)
            {
                return HttpNotFound();
            }
            return View(loanInformation);
        }

        // GET: LoanInformations/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(_db.Students, "Id", "MobilNo");
            return View();
        }

        // POST: LoanInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LoanDate,ReturnDate,IsEmailSend,IsReservation,ReservationDate,StudentId")] LoanInformation loanInformation)
        {
            if (ModelState.IsValid)
            {
                _db.LoanInformations.Add(loanInformation);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(_db.Students, "Id", "MobilNo", loanInformation.StudentId);
            return View(loanInformation);
        }

        // GET: LoanInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var loanInformation = _db.LoanInformations.Find(id);
            if (loanInformation == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(_db.Students, "Id", "MobilNo", loanInformation.StudentId);
            return View(loanInformation);
        }

        // POST: LoanInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LoanDate,ReturnDate,IsEmailSend,IsReservation,ReservationDate,StudentId")] LoanInformation loanInformation)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(loanInformation).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(_db.Students, "Id", "MobilNo", loanInformation.StudentId);
            return View(loanInformation);
        }

        // GET: LoanInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var loanInformation = _db.LoanInformations.Find(id);
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
            var loanInformation = _db.LoanInformations.Find(id);
            _db.LoanInformations.Remove(loanInformation);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}