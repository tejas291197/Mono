using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class StoreGroupMaster
    {
        public int Id { get; set; }
        public string ImporterName { get; set; }
        public string DealerName { get; set; }
        public string StoreGroupName { get; set; }
        public string StoreGroupPhone { get; set; }
        public string StoreGroupRegion { get; set; }          
        public string Email { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
