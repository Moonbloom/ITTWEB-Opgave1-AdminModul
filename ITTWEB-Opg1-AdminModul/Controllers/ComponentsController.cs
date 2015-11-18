using System.Linq;
using System.Net;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.DAL;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ComponentsController : Controller
    {
        private readonly EsDbManager _esDbManager = new EsDbManager();

        // GET: Components
        public ActionResult Index()
        {
            var components = _esDbManager.GetAllComponents();
            return View(components.ToList());
        }

        // GET: Components/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var component = _esDbManager.GetComponent(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            return View(component);
        }

        // GET: Components/Create
        public ActionResult Create()
        {
            ViewBag.ComponentTypeId = new SelectList(_esDbManager.GetComponentTypes(), "Id", "ComponentName");
            ViewBag.LoanInformationId = new SelectList(_esDbManager.GetLoanInformations(), "Id", "Id");
            return View();
        }

        // POST: Components/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id,ComponentNumber,SerieNr,AdminComment,UserComment,ComponentTypeId,LoanInformationId")] Component component)
        {
            if (ModelState.IsValid)
            {
                _esDbManager.CreateComponent(component);
                return RedirectToAction("Index");
            }

            ViewBag.ComponentTypeId = new SelectList(_esDbManager.GetComponentTypes(), "Id", "ComponentName", component.ComponentTypeId);
            ViewBag.LoanInformationId = new SelectList(_esDbManager.GetLoanInformations(), "Id", "Id", component.LoanInformationId);
            return View(component);
        }

        // GET: Components/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var component = _esDbManager.GetComponent(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            ViewBag.ComponentTypeId = new SelectList(_esDbManager.GetComponentTypes(), "Id", "ComponentName",
                component.ComponentTypeId);
            ViewBag.LoanInformationId = new SelectList(_esDbManager.GetLoanInformations(), "Id", "Id", component.LoanInformationId);
            return View(component);
        }

        // POST: Components/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "Id,ComponentNumber,SerieNr,AdminComment,UserComment,ComponentTypeId,LoanInformationId")] Component component)
        {
            if (ModelState.IsValid)
            {
                _esDbManager.UpdateComponent(component);
                return RedirectToAction("Index");
            }
            ViewBag.ComponentTypeId = new SelectList(_esDbManager.GetComponentTypes(), "Id", "ComponentName", component.ComponentTypeId);
            ViewBag.LoanInformationId = new SelectList(_esDbManager.GetLoanInformations(), "Id", "Id", component.LoanInformationId);
            return View(component);
        }

        // GET: Components/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var component = _esDbManager.GetComponent(id);
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
            _esDbManager.DeleteComponent(id);
            return RedirectToAction("Index");
        }
    }
}