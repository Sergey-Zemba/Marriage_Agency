using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Marriage_Agency_Women_.Models.Woman;

namespace Marriage_Agency_Women_.Controllers
{
    public class WomanController : Controller
    {
        private WomanContext db = new WomanContext();

        // GET: Woman
        public ActionResult Index()
        {
            return View(db.Women.ToList());
        }

        // GET: Woman/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Woman woman = db.Women.Find(id);
            if (woman == null)
            {
                return HttpNotFound();
            }
            return View(woman);
        }

        // GET: Woman/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Woman/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Status,FirstName,LastName,Birthday,Age,Country,City,Nationality,Religion,Job,Education,MaritalStatus,NumberOfChildren,Height,Weight,EyeColor,HairColor,Smoking,Alcohol,DesiredAge,Hobby,PhoneNumber,Email,Skype,Facebook,Vk,Twitter,InternationalPassport")] Woman woman)
        {
            if (ModelState.IsValid)
            {
                db.Women.Add(woman);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(woman);
        }

        // GET: Woman/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Woman woman = db.Women.Find(id);
            if (woman == null)
            {
                return HttpNotFound();
            }
            return View(woman);
        }

        // POST: Woman/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Status,FirstName,LastName,Birthday,Age,Country,City,Nationality,Religion,Job,Education,MaritalStatus,NumberOfChildren,Height,Weight,EyeColor,HairColor,Smoking,Alcohol,DesiredAge,Hobby,PhoneNumber,Email,Skype,Facebook,Vk,Twitter,InternationalPassport")] Woman woman)
        {
            if (ModelState.IsValid)
            {
                db.Entry(woman).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(woman);
        }

        // GET: Woman/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Woman woman = db.Women.Find(id);
            if (woman == null)
            {
                return HttpNotFound();
            }
            return View(woman);
        }

        // POST: Woman/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Woman woman = db.Women.Find(id);
            db.Women.Remove(woman);
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
