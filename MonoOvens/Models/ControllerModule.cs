using System;
using System.Collections.Generic;

namespace MonoOvens.Models
{
    public partial class ControllerModule
    {
        public int Id { get; set; }
        public string FG_Code { get; set; }
        public string SerialNumber { get; set; }
        public string AuthenticationCode { get; set; }
        public string FirmwareVersion { get; set; }
        public string SoftwareVersion { get; set; }
        public string RecipeVersion { get; set; }
        public string Skins { get; set; }
        public string Wallpaper { get; set; }
        public TimeSpan? SevenDayTimer { get; set; }
        public string SleepDelay { get; set; }
        public DateTime? ControllerDate { get; set; }
        public bool? Status { get; set; }
        // enable or disable.
        public bool RemoteKill { get; set; }

        // fields added for the power consumptions for perticuler controller.
        //public string Power { get; set; }
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
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

    }

}
