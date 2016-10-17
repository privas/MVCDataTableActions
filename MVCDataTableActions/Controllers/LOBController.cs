using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDataTableActions.Models;

namespace MVCDataTableActions.Controllers
{
    public class LOBController : Controller
    {
        private FileEntriesDb db = new FileEntriesDb();

        //
        // GET: /LOB/

        public ActionResult Index()
        {
            return View(db.LOBs.ToList());
        }

        //
        // GET: /LOB/Details/5

        public ActionResult Details(int id = 0)
        {
            LOB lob = db.LOBs.Find(id);
            if (lob == null)
            {
                return HttpNotFound();
            }
            return View(lob);
        }

        //
        // GET: /LOB/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LOB/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LOB lob)
        {
            if (ModelState.IsValid)
            {
                db.LOBs.Add(lob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lob);
        }

        //
        // GET: /LOB/Edit/5

        public ActionResult Edit(int id = 0)
        {
            LOB lob = db.LOBs.Find(id);
            if (lob == null)
            {
                return HttpNotFound();
            }
            return View(lob);
        }

        //
        // POST: /LOB/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LOB lob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lob);
        }

        //
        // GET: /LOB/Delete/5

        public ActionResult Delete(int id = 0)
        {
            LOB lob = db.LOBs.Find(id);
            if (lob == null)
            {
                return HttpNotFound();
            }
            return View(lob);
        }

        //
        // POST: /LOB/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LOB lob = db.LOBs.Find(id);
            db.LOBs.Remove(lob);
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