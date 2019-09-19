using System;
using System.Collections.Generic;

namespace MonoOvens.Models
{
    public partial class ControllerModule
    {
        public int Id { get; set; }
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
    
        public bool RemoteKill { get; set; }
    }

}
