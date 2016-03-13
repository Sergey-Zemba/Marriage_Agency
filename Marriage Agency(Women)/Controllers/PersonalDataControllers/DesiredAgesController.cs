using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Marriage_Agency_Women_.Models.Characteristics;
using Marriage_Agency_Women_.Models.IdentityModels;

namespace Marriage_Agency_Women_.Controllers.PersonalDataControllers
{
    public class DesiredAgesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DesiredAges
        public ActionResult Index()
        {
            return View(db.DesiredAges.ToList().OrderBy(d => d.Position));
        }

        // GET: DesiredAges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DesiredAge desiredAge = db.DesiredAges.Find(id);
            if (desiredAge == null)
            {
                return HttpNotFound();
            }
            return View(desiredAge);
        }

        // GET: DesiredAges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DesiredAges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] DesiredAge desiredAge)
        {
            if (ModelState.IsValid)
            {
                db.DesiredAges.Add(desiredAge);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(desiredAge);
        }

        // GET: DesiredAges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DesiredAge desiredAge = db.DesiredAges.Find(id);
            if (desiredAge == null)
            {
                return HttpNotFound();
            }
            return View(desiredAge);
        }

        // POST: DesiredAges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] DesiredAge desiredAge)
        {
            if (ModelState.IsValid)
            {
                db.Entry(desiredAge).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(desiredAge);
        }

        // GET: DesiredAges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DesiredAge desiredAge = db.DesiredAges.Find(id);
            if (desiredAge == null)
            {
                return HttpNotFound();
            }
            return View(desiredAge);
        }

        // POST: DesiredAges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DesiredAge desiredAge = db.DesiredAges.Find(id);
            db.DesiredAges.Remove(desiredAge);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
