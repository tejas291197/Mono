using System;
using System.Collections.Generic;

namespace MonoOvens.Models
{
    public partial class Manufacturer
    {
        public int Id { get; set; }
        public string ManufacturerId { get; set; }
        public string SupName { get; set; }
        public string SupAddressLine1 { get; set; }
        public string SupAddressLine2 { get; set; }
        public string SupArea { get; set; }
        public string SupCity { get; set; }
        public string SupState { get; set; }
        public decimal? SupPhone { get; set; }
        public string SupEmail { get; set; }
    }
}
