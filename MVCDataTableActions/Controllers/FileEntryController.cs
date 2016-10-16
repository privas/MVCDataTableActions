using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCDataTableActions.Models;

namespace MVCDataTableActions.Controllers
{
    public class FileEntryController : Controller
    {
        FileEntriesDb _db = new FileEntriesDb();

        public ActionResult Index(string searchTerm = null)
        {
            var model =
                _db.FileEntries
                    .OrderByDescending(r => r.DOLoading)
                    .Where(r => searchTerm == null || r.OriginalFileName.StartsWith(searchTerm))
                    .Select(r => new FileEntryViewModel
                            {
                                ID = r.FileEntryID,
                                SavedFileName = r.SavedFileName,
                                OriginalFileName = r.OriginalFileName,
                                DOS = r.DOService,
                                DOL = r.DOLoading,
                                Status = r.DOService.ToString()
                            });

                //from r in _db.FileEntries
                //orderby r.DOLoading descending
                //select new FileEntryViewModel
                //{
                //    ID = r.ID,
                //    FileName = r.SavedFileName,
                //    DOS = r.DOService,
                //    DOL = r.DOLoading,
                //    Status = r.DOService.ToString()
                //};

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
                _db.Dispose();

            base.Dispose(disposing);
        }
    }
}
