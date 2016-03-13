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
    public class AlcoholsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Alcohols
        public ActionResult Index()
        {
            return View(db.Alcohols.ToList().OrderBy(a => a.Position));
        }

        // GET: Alcohols/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alcohol alcohol = db.Alcohols.Find(id);
            if (alcohol == null)
            {
                return HttpNotFound();
            }
            return View(alcohol);
        }

        // GET: Alcohols/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alcohols/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Alcohol alcohol)
        {
            if (ModelState.IsValid)
            {
                db.Alcohols.Add(alcohol);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alcohol);
        }

        // GET: Alcohols/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alcohol alcohol = db.Alcohols.Find(id);
            if (alcohol == null)
            {
                return HttpNotFound();
            }
            return View(alcohol);
        }

        // POST: Alcohols/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Alcohol alcohol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alcohol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alcohol);
        }

        // GET: Alcohols/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alcohol alcohol = db.Alcohols.Find(id);
            if (alcohol == null)
            {
                return HttpNotFound();
            }
            return View(alcohol);
        }

        // POST: Alcohols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alcohol alcohol = db.Alcohols.Find(id);
            db.Alcohols.Remove(alcohol);
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
