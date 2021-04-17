using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScheduleJSON
{
    /// <summary>   
    /// Represents custom data properties.   
    /// </summary>  
    public class Meeting
    {
        public string EventName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool AllDay { get; set; }
        public Color Color { get; set; }
    }
}
