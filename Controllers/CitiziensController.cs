using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspDotNetMVC.Context;
using AspDotNetMVC.Models;

namespace AspDotNetMVC.Controllers
{
    public class CitiziensController : Controller
    {
        private AspDotNetMVCContext db = new AspDotNetMVCContext();

        // GET: Citiziens
        public ActionResult Index()
        {
            return View(db.Citiziens.ToList());
        }

        // GET: Citiziens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizien citizien = db.Citiziens.Find(id);
            if (citizien == null)
            {
                return HttpNotFound();
            }
            return View(citizien);
        }

        // GET: Citiziens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Citiziens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,rank")] Citizien citizien)
        {
            if (ModelState.IsValid)
            {
                db.Citiziens.Add(citizien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(citizien);
        }

        // GET: Citiziens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizien citizien = db.Citiziens.Find(id);
            if (citizien == null)
            {
                return HttpNotFound();
            }
            return View(citizien);
        }

        // POST: Citiziens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,rank")] Citizien citizien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(citizien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(citizien);
        }

        // GET: Citiziens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizien citizien = db.Citiziens.Find(id);
            if (citizien == null)
            {
                return HttpNotFound();
            }
            return View(citizien);
        }

        // POST: Citiziens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Citizien citizien = db.Citiziens.Find(id);
            db.Citiziens.Remove(citizien);
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
