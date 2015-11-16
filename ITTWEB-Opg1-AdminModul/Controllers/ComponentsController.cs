using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly EsDbContext _db = new EsDbContext();

        // GET: Components
        public ActionResult Index()
        {
            var components = _db.Components.Include(c => c.ComponentType).Include(c => c.LoanInformation);
            return View(components.ToList());
        }

        // GET: Components/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var component = _db.Components.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            return View(component);
        }

        // GET: Components/Create
        public ActionResult Create()
        {
            ViewBag.ComponentTypeId = new SelectList(_db.ComponentTypes, "Id", "ComponentName");
            ViewBag.LoanInformationId = new SelectList(_db.LoanInformations, "Id", "Id");
            return View();
        }

        // POST: Components/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ComponentNumber,SerieNr,AdminComment,UserComment,ComponentTypeId,LoanInformationId")] Component component)
        {
            if (ModelState.IsValid)
            {
                _db.Components.Add(component);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ComponentTypeId = new SelectList(_db.ComponentTypes, "Id", "ComponentName", component.ComponentTypeId);
            ViewBag.LoanInformationId = new SelectList(_db.LoanInformations, "Id", "Id", component.LoanInformationId);
            return View(component);
        }

        // GET: Components/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var component = _db.Components.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            ViewBag.ComponentTypeId = new SelectList(_db.ComponentTypes, "Id", "ComponentName", component.ComponentTypeId);
            ViewBag.LoanInformationId = new SelectList(_db.LoanInformations, "Id", "Id", component.LoanInformationId);
            return View(component);
        }

        // POST: Components/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ComponentNumber,SerieNr,AdminComment,UserComment,ComponentTypeId,LoanInformationId")] Component component)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(component).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ComponentTypeId = new SelectList(_db.ComponentTypes, "Id", "ComponentName", component.ComponentTypeId);
            ViewBag.LoanInformationId = new SelectList(_db.LoanInformations, "Id", "Id", component.LoanInformationId);
            return View(component);
        }

        // GET: Components/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var component = _db.Components.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            return View(component);
        }

        // POST: Components/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var component = _db.Components.Find(id);
            _db.Components.Remove(component);
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