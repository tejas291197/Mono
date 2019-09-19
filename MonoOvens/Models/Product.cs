using System;
using System.Collections.Generic;

namespace MonoOvens.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategoryId { get; set; }
        public string ProductSubCategoryId { get; set; }
        public string ProductTypeId { get; set; }
        public string ManufacturerId { get; set; }

        public Product Manufacturer { get; set; }
        public Product InverseManufacturer { get; set; }
    }
}
