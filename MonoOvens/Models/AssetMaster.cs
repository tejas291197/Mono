using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class AssetMaster
    {
        public int Id { get; set; }
        public int AssetCategory  { get; set; }
        public int AssetType  { get; set; }
        public int ControllerType { get; set; }
        public int Controllers { get; set; }
        public int Trays { get; set; }
        public string TrayHeight_inch { get; set; }
        public string TrayWidth_inch { get; set; }
        public string Handed { get; set; }
        public string Format { get; set; }
        public string Power { get; set; }
        public string PowerConsumption  { get; set; }

        public bool IsDeleted { get; set; }



    }
}
