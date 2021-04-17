using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleJSON
{
    /// <summary>   
    /// Represents custom data properties.   
    /// </summary>  
    public class JSONData
    {
        public string Subject { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string IsAllDay { get; set; }
        public string Background { get; set; }
    }
}
