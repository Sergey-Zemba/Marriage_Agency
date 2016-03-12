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
    public class InternationalPassportsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: InternationalPassports
        public ActionResult Index()
        {
            return View(db.InternationalPassports.ToList());
        }

        // GET: InternationalPassports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InternationalPassport internationalPassport = db.InternationalPassports.Find(id);
            if (internationalPassport == null)
            {
                return HttpNotFound();
            }
            return View(internationalPassport);
        }

        // GET: InternationalPassports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InternationalPassports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] InternationalPassport internationalPassport)
        {
            if (ModelState.IsValid)
            {
                db.InternationalPassports.Add(internationalPassport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(internationalPassport);
        }

        // GET: InternationalPassports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InternationalPassport internationalPassport = db.InternationalPassports.Find(id);
            if (internationalPassport == null)
            {
                return HttpNotFound();
            }
            return View(internationalPassport);
        }

        // POST: InternationalPassports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] InternationalPassport internationalPassport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(internationalPassport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(internationalPassport);
        }

        // GET: InternationalPassports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InternationalPassport internationalPassport = db.InternationalPassports.Find(id);
            if (internationalPassport == null)
            {
                return HttpNotFound();
            }
            return View(internationalPassport);
        }

        // POST: InternationalPassports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InternationalPassport internationalPassport = db.InternationalPassports.Find(id);
            db.InternationalPassports.Remove(internationalPassport);
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
