using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class RegController : Controller
    {
        private RegContext db = new RegContext();

        //
        // GET: /Reg/

        public ActionResult Index()
        {
            return View(db.Regs.ToList());
        }

        //
        // GET: /Reg/Details/5

        public ActionResult Details(int id = 0)
        {
            Reg reg = db.Regs.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }

        //
        // GET: /Reg/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reg/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reg reg)
        {
            if (ModelState.IsValid)
            {
                db.Regs.Add(reg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reg);
        }

        //
        // GET: /Reg/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Reg reg = db.Regs.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }

        //
        // POST: /Reg/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Reg reg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reg);
        }

        //
        // GET: /Reg/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Reg reg = db.Regs.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }

        //
        // POST: /Reg/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reg reg = db.Regs.Find(id);
            db.Regs.Remove(reg);
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