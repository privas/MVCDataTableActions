using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataTableActions.Models
{
    public class FileEntryVM
    {
        public FileEntry fileEntry { get; set; }
        public List<FileEntry> fileEntries { get; set; }
        public string Status
        {
            get;
            set;
        }
    }
}