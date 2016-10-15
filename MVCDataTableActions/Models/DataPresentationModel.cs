using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataTableActions.Models
{
    public class DataPresentationModel
    {
        public int ID { get; set; }
        public string ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string ProviderSpecialty{ get; set; }
        public string LOB { get; set; }
        public string MemberNo { get; set; }
        public string MemberName { get; set; }
        public DateTime DOService{ get; set; }
        public DateTime DOLoading { get; set; }
        public string SavedFileName { get; set; }
        public string OriginalFileName{ get; set; }
        public string TypeOfFile{ get; set; }

    }
}