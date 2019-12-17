using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class StoreMaster
    {
        public int Id { get; set; }
        public string ImporterName { get; set; }
        public string DealerName { get; set; }
        public string StoreGroupName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
        public string StoreCode { get; set; }
        public string Type { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress1 { get; set; }
        public string StoreAddress2 { get; set; }
        public string PostTown { get; set; }
        public string StorePostcode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

    }
}
