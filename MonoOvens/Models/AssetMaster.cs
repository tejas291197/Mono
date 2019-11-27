using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class AssetMaster
    {
        public int Id { get; set; }
        public string FG_Code { get; set; }
        public int AssetCategory  { get; set; }
        public int AssetType  { get; set; }
        public int ControllerType { get; set; }
        public int Controllers { get; set; }
        public int Trays { get; set; }
        public string TraySize { get; set; }
      
        public string Handed { get; set; }
        public string Format { get; set; }
        public string Power { get; set; }
        // public string PowerConsumption  { get; set; }
        //  all the fields related to power Consumption of a controllers of an Oven.
        public int Elements { get; set; }
        public float kWh_Rating_Element { get; set; }
        public string LightType { get; set; }
        public int Lights { get; set; }
        public float kWh_Rating_Light { get; set; }
        public int Fans { get; set; }
        public float kWh_Rating_Fan  { get; set; }
        public float kWh_Rating_Damper { get; set; }
        public float kWh_Rating_WaterSolenoid { get; set; }
        public bool IsDeleted { get; set; }



    }
}
