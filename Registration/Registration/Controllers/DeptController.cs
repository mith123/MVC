﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class DeptController : Controller
    {
        private RegContext db = new RegContext();

        //
        // GET: /Dept/

        public ActionResult Index()
        {
            return View(db.Depts.ToList());
        }

        //
        // GET: /Dept/Details/5

        public ActionResult Details(int id = 0)
        {
            Dept dept = db.Depts.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            return View(dept);
        }

        //
        // GET: /Dept/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Dept/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dept dept)
        {
            if (ModelState.IsValid)
            {
                db.Depts.Add(dept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dept);
        }

        //
        // GET: /Dept/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Dept dept = db.Depts.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            return View(dept);
        }

        //
        // POST: /Dept/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Dept dept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dept).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dept);
        }

        //
        // GET: /Dept/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Dept dept = db.Depts.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            return View(dept);
        }

        //
        // POST: /Dept/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dept dept = db.Depts.Find(id);
            db.Depts.Remove(dept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}