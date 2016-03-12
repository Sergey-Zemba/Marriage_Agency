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
    public class HairColorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HairColors
        public ActionResult Index()
        {
            return View(db.HairColors.ToList());
        }

        // GET: HairColors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HairColor hairColor = db.HairColors.Find(id);
            if (hairColor == null)
            {
                return HttpNotFound();
            }
            return View(hairColor);
        }

        // GET: HairColors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HairColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] HairColor hairColor)
        {
            if (ModelState.IsValid)
            {
                db.HairColors.Add(hairColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hairColor);
        }

        // GET: HairColors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HairColor hairColor = db.HairColors.Find(id);
            if (hairColor == null)
            {
                return HttpNotFound();
            }
            return View(hairColor);
        }

        // POST: HairColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] HairColor hairColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hairColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hairColor);
        }

        // GET: HairColors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HairColor hairColor = db.HairColors.Find(id);
            if (hairColor == null)
            {
                return HttpNotFound();
            }
            return View(hairColor);
        }

        // POST: HairColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HairColor hairColor = db.HairColors.Find(id);
            db.HairColors.Remove(hairColor);
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
