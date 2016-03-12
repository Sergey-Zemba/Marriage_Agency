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
    public class SmokingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Smokings
        public ActionResult Index()
        {
            return View(db.Smokings.ToList());
        }

        // GET: Smokings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smoking smoking = db.Smokings.Find(id);
            if (smoking == null)
            {
                return HttpNotFound();
            }
            return View(smoking);
        }

        // GET: Smokings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Smokings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Smoking smoking)
        {
            if (ModelState.IsValid)
            {
                db.Smokings.Add(smoking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(smoking);
        }

        // GET: Smokings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smoking smoking = db.Smokings.Find(id);
            if (smoking == null)
            {
                return HttpNotFound();
            }
            return View(smoking);
        }

        // POST: Smokings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Smoking smoking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smoking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(smoking);
        }

        // GET: Smokings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smoking smoking = db.Smokings.Find(id);
            if (smoking == null)
            {
                return HttpNotFound();
            }
            return View(smoking);
        }

        // POST: Smokings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Smoking smoking = db.Smokings.Find(id);
            db.Smokings.Remove(smoking);
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
