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
    public class LifestylesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Lifestyles
        public ActionResult Index()
        {
            return View(db.Lifestyles.ToList().OrderBy(l => l.Position));
        }

        // GET: Lifestyles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lifestyle lifestyle = db.Lifestyles.Find(id);
            if (lifestyle == null)
            {
                return HttpNotFound();
            }
            return View(lifestyle);
        }

        // GET: Lifestyles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lifestyles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Lifestyle lifestyle)
        {
            if (ModelState.IsValid)
            {
                db.Lifestyles.Add(lifestyle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lifestyle);
        }

        // GET: Lifestyles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lifestyle lifestyle = db.Lifestyles.Find(id);
            if (lifestyle == null)
            {
                return HttpNotFound();
            }
            return View(lifestyle);
        }

        // POST: Lifestyles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Lifestyle lifestyle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lifestyle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lifestyle);
        }

        // GET: Lifestyles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lifestyle lifestyle = db.Lifestyles.Find(id);
            if (lifestyle == null)
            {
                return HttpNotFound();
            }
            return View(lifestyle);
        }

        // POST: Lifestyles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lifestyle lifestyle = db.Lifestyles.Find(id);
            var users = db.Users.Where(u => u.Lifestyle.RussianName == lifestyle.RussianName);
            foreach (var user in users)
            {
                user.Lifestyle = null;
            }
            db.Lifestyles.Remove(lifestyle);
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
