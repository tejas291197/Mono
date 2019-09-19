using System;
using System.Collections.Generic;

namespace MonoOvens.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string ShippedDate { get; set; }
        public DateTime OrderDate { get; set; }
        public string ManufacturerId { get; set; }
        public string ClientId { get; set; }
        public string ProductId { get; set; }
        public string DealerId { get; set; }
        public string OrderedQuantity { get; set; }
        public string ShippedQuantity { get; set; }
    }
}
