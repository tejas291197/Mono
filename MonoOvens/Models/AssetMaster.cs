using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class AssetMaster
    {
        public int Id { get; set; }
        public string AssetCategory  { get; set; }
        public string AssetType  { get; set; }
        public string ControllerType { get; set; }
        public int Controllers { get; set; }
        public int Trays { get; set; }
        public string TrayHeight_inch { get; set; }
        public string TrayWidth_inch { get; set; }
        public string Handed { get; set; }
        public string Format { get; set; }
        public string Power { get; set; }
        public string PowerConsumption  { get; set; }
       




    }
}
