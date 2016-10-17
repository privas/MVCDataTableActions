using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

using MVCDataTableActions.Models;

namespace MVCDataTableActions.Controllers
{
    public class FileEntryController : Controller
    {
        FileEntriesDb _db = new FileEntriesDb();

        public ActionResult Index([Bind(Prefix="id")] int providerid)
        {
            var provider = _db.Providers.Find(providerid);
            if (provider != null)
            {
                return View(provider);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int providerid)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FileEntry fileEntry)
        {
            if (ModelState.IsValid)
            {
                _db.FileEntries.Add(fileEntry);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = fileEntry.ProviderID });
            }
            return View(fileEntry);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.FileEntries.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(FileEntry fileEntry)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(fileEntry).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = fileEntry.ProviderID });
            }
            return View(fileEntry);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
