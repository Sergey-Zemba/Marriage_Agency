﻿using System;
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
    public class ShapesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Shapes
        public ActionResult Index()
        {
            return View(db.Shapes.ToList().OrderBy(s => s.Position));
        }

        // GET: Shapes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shape shape = db.Shapes.Find(id);
            if (shape == null)
            {
                return HttpNotFound();
            }
            return View(shape);
        }

        // GET: Shapes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shapes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Shape shape)
        {
            if (ModelState.IsValid)
            {
                db.Shapes.Add(shape);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shape);
        }

        // GET: Shapes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shape shape = db.Shapes.Find(id);
            if (shape == null)
            {
                return HttpNotFound();
            }
            return View(shape);
        }

        // POST: Shapes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,RussianName,EnglishName,JapaneseName")] Shape shape)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shape).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shape);
        }

        // GET: Shapes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shape shape = db.Shapes.Find(id);
            if (shape == null)
            {
                return HttpNotFound();
            }
            return View(shape);
        }

        // POST: Shapes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shape shape = db.Shapes.Find(id);
            var users = db.Users.Where(u => u.Shape.RussianName == shape.RussianName);
            foreach (var user in users)
            {
                user.Shape = null;
            }
            db.Shapes.Remove(shape);
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
