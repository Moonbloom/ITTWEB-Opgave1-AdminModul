using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ITTWEB_Opg1_AdminModul.DAL;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ComponentTypesController : Controller
    {
        private readonly EsDbManager _esDbManager = new EsDbManager();

        // GET: ComponentTypes
        public ActionResult Index()
        {
            var componentTypes = _esDbManager.GetAllComponentTypes();
            return View(componentTypes.ToList());
        }

        // GET: ComponentTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var componentType = _esDbManager.GetComponentType(id);
            if (componentType == null)
            {
                return HttpNotFound();
            }
            return View(componentType);
        }

        // GET: ComponentTypes/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(_esDbManager.GetCategories(), "Id", "CategoryName");
            return View();
        }

        // POST: ComponentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id,ComponentName,ComponentInfo,Datasheet,LocalImageUrl,ManufacturerLink,CategoryId")] ComponentType componentType)
        {
            if (ModelState.IsValid)
            {
                _esDbManager.CreateComponentType(componentType);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(_esDbManager.GetCategories(), "Id", "CategoryName", componentType.CategoryId);
            return View(componentType);
        }

        // GET: ComponentTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var componentType = _esDbManager.GetComponentType(id);
            if (componentType == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(_esDbManager.GetCategories(), "Id", "CategoryName", componentType.CategoryId);
            return View(componentType);
        }

        // POST: ComponentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "Id,ComponentName,ComponentInfo,Datasheet,LocalImageUrl,ManufacturerLink,CategoryId")] ComponentType componentType)
        {
            if (ModelState.IsValid)
            {
                _esDbManager.UpdateComponentType(componentType);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(_esDbManager.GetCategories(), "Id", "CategoryName", componentType.CategoryId);
            return View(componentType);
        }

        // GET: ComponentTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var componentType = _esDbManager.GetComponentType(id);
            if (componentType == null)
            {
                return HttpNotFound();
            }
            return View(componentType);
        }

        // POST: ComponentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _esDbManager.DeleteComponentType(id);
            return RedirectToAction("Index");
        }
    }
}