using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataTableActions.Models
{
    public class Provider
    {
        public int ProviderID { get; set; }
        public string Name { get; set; }
        public int LOBID { get; set; }
        public virtual ICollection<FileEntry> FileEntries { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}