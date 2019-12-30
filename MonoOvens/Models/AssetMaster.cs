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
        public int Elements { get; set; }
        public float kWh_Rating_Element { get; set; }
        public string LightType { get; set; }
        public int Lights { get; set; }
        public float kWh_Rating_Light { get; set; }
        public int Fans { get; set; }
        public float kWh_Rating_Fan { get; set; }
        public float kWh_Rating_Damper { get; set; }
        public float kWh_Rating_WaterSolenoid { get; set; }
        public string CreatedBy { get; set; }

        public string Handed { get; set; }
        public string Format { get; set; }
        public string Power { get; set; }       
        public string modifiedby { get; set; }
        public bool IsDeleted { get; set; }



    }
}
