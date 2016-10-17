using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataTableActions.Models
{
    public class FileEntry
    {
        public int FileEntryID { get; set; }
        public int ProviderID{ get; set; }
        public string SavedFileName { get; set; }
        public string OriginalFileName{ get; set; }
        public string FileExtension { get; set; }
        public DateTime DOLoading { get; set; }
        public Nullable<DateTime> DOService { get; set; }
    }
}