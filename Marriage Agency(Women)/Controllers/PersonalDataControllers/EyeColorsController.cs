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
    [Authorize(Roles = "admin,superadmin")]
    public class EyeColorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EyeColors
        public ActionResult Index()
        {
            return View(db.EyeColors.ToList().OrderBy(e => e.Position));
        }

        // GET: EyeColors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EyeColor eyeColor = db.EyeColors.Find(id);
            if (eyeColor == null)
            {
                return HttpNotFound();
            }
            return View(eyeColor);
        }

        // GET: EyeColors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EyeColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] EyeColor eyeColor)
        {
            if (ModelState.IsValid)
            {
                db.EyeColors.Add(eyeColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eyeColor);
        }

        // GET: EyeColors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EyeColor eyeColor = db.EyeColors.Find(id);
            if (eyeColor == null)
            {
                return HttpNotFound();
            }
            return View(eyeColor);
        }

        // POST: EyeColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] EyeColor eyeColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eyeColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eyeColor);
        }

        // GET: EyeColors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EyeColor eyeColor = db.EyeColors.Find(id);
            if (eyeColor == null)
            {
                return HttpNotFound();
            }
            return View(eyeColor);
        }

        // POST: EyeColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EyeColor eyeColor = db.EyeColors.Find(id);
            var users = db.Users.Where(u => u.EyeColor.RussianName == eyeColor.RussianName);
            foreach (var user in users)
            {
                user.EyeColor = null;
            }
            db.EyeColors.Remove(eyeColor);
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
