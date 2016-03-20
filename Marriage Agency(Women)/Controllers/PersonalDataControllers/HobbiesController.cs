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
    public class HobbiesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Hobbies
        public ActionResult Index()
        {
            return View(db.Hobbies.ToList().OrderBy(h => h.Position));
        }

        // GET: Hobbies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobby hobby = db.Hobbies.Find(id);
            if (hobby == null)
            {
                return HttpNotFound();
            }
            return View(hobby);
        }

        // GET: Hobbies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hobbies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Hobby hobby)
        {
            if (ModelState.IsValid)
            {
                db.Hobbies.Add(hobby);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hobby);
        }

        // GET: Hobbies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobby hobby = db.Hobbies.Find(id);
            if (hobby == null)
            {
                return HttpNotFound();
            }
            return View(hobby);
        }

        // POST: Hobbies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Hobby hobby)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hobby).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hobby);
        }

        // GET: Hobbies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobby hobby = db.Hobbies.Find(id);
            if (hobby == null)
            {
                return HttpNotFound();
            }
            return View(hobby);
        }

        // POST: Hobbies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hobby hobby = db.Hobbies.Find(id);
            var users = db.Users.Where(u => u.Hobby.RussianName == hobby.RussianName);
            foreach (var user in users)
            {
                user.Hobby = null;
            }
            db.Hobbies.Remove(hobby);
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
