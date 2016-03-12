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
    public class NumberOfChildrensController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NumberOfChildrens
        public ActionResult Index()
        {
            return View(db.NumbersOfChildren.ToList());
        }

        // GET: NumberOfChildrens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NumberOfChildren numberOfChildren = db.NumbersOfChildren.Find(id);
            if (numberOfChildren == null)
            {
                return HttpNotFound();
            }
            return View(numberOfChildren);
        }

        // GET: NumberOfChildrens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NumberOfChildrens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] NumberOfChildren numberOfChildren)
        {
            if (ModelState.IsValid)
            {
                db.NumbersOfChildren.Add(numberOfChildren);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(numberOfChildren);
        }

        // GET: NumberOfChildrens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NumberOfChildren numberOfChildren = db.NumbersOfChildren.Find(id);
            if (numberOfChildren == null)
            {
                return HttpNotFound();
            }
            return View(numberOfChildren);
        }

        // POST: NumberOfChildrens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] NumberOfChildren numberOfChildren)
        {
            if (ModelState.IsValid)
            {
                db.Entry(numberOfChildren).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(numberOfChildren);
        }

        // GET: NumberOfChildrens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NumberOfChildren numberOfChildren = db.NumbersOfChildren.Find(id);
            if (numberOfChildren == null)
            {
                return HttpNotFound();
            }
            return View(numberOfChildren);
        }

        // POST: NumberOfChildrens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NumberOfChildren numberOfChildren = db.NumbersOfChildren.Find(id);
            db.NumbersOfChildren.Remove(numberOfChildren);
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
