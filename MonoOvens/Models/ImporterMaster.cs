using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class ImporterMaster
    {
        public int Id { get; set; }
        public string ImporterName { get; set; }
        public string ImporterPhone { get; set; }
        public string ImporterRegion { get; set; }       
        public string Email { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
         public bool IsDeleted { get; set; }
    }
}
