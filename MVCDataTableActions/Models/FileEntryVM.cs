using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataTableActions.Models
{
    public class FileEntryViewModel
    {
        public int ID { get; set; }
        public string SavedFileName{ get; set; }
        public string OriginalFileName { get; set; }
        public int ProviderID { get; set; }
        public DateTime DOL{ get; set; }
        public Nullable<DateTime> DOS { get; set; }
        public string Status { get; set; }
    }
}