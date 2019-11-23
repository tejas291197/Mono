using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonoOvens.Models
{
    public  class DealerMaster
    {
    
        public int Id { get; set; }
      
        public string DealerName { get; set; }
        public string DealerPhone { get; set; }
        public string DealerRegion { get; set; }
        public bool IsDeleted { get; set; }
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
