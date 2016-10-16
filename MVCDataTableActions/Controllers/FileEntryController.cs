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
        public ActionResult Index()
        {
            DAL dal = new DAL();
            FileEntryVM fileEntryVM = new FileEntryVM();
            fileEntryVM.fileEntries = new List<FileEntry>();
            fileEntryVM.fileEntries = dal.FileEntryMaster.ToList<FileEntry>();
            return View(fileEntryVM);
        }

    }
}
