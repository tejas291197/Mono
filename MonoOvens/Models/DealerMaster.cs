using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonoOvens.Models
{
    public class DealerMaster
    {
        //public int Id { get; set; }
        //public string DealerName { get; set; }
        //public string DealerPhone { get; set; }
        //public string DealerRegion { get; set; }

        //public string CustomerName { get; set; }
        //public string CustomerNumber { get; set; }
        //public string Email { get; set; }
      
        //public string Region { get; set; }
        //public string Area { get; set; }
        //public string StoreCode { get; set; }
        //public string Type { get; set; }
        //public string StoreName { get; set; }
        //public string StoreAddress1 { get; set; }
        //public string StoreAddress2 { get; set; }
        //public string PostTown { get; set; }
        //public string StorePostcode { get; set; }
        //public bool IsDeleted { get; set; }

        public int Id { get; set; }
        public string ImporterName { get; set; }
        public string DealerName { get; set; }
        public string DealerPhone { get; set; }
        public string DealerRegion { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

   //     string IName;

        //[Required]
        //[EmailAddress]
        //public string DealerEmail { get; set; }
        //public string DealerAddressLine1 { get; set; }
        //public string DealerAddressLine2 { get; set; }
        //public string DealerArea { get; set; }
        //public string DealerCity { get; set; }
        //public string DealerState { get; set; }
        //public string DealerCountry { get; set; }
    }
}
