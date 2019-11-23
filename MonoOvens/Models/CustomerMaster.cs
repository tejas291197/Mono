using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class CustomerMaster
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string HOAddress1 { get; set; }
        public string HOAddress2 { get; set; }
        public string HOAddress3 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactNumber { get; set; }        
        public string PrimaryEmail { get; set; }


        public string Zone { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
        public string StoreCode { get; set; }
        public string Type { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress1 { get; set; }
        public string StoreAddress2 { get; set; }
        public string PostTown { get; set; }

        public string StorePostcode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
