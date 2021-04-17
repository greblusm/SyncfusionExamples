using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ScheduleJSON
{
    /// <summary>   
    /// Represents collection of appointments.   
    /// </summary>
    public class ViewModel : ContentPage
    {
        public ObservableCollection<Meeting> Meetings { get; set; }

        private string JsonData =
            "[{\"Subject\": \"General Meeting\",\"StartTime\": \"30-08-2018 15:00:00\",\"EndTime\":\"30-08-2018 16:00:00\",\"Background\":\"#5944dd\", \"IsAllDay\":\"True\"}, " +
            "{\"Subject\": \"Plan Execution\",\"StartTime\": \"22-08-2018 10:00:00\",\"EndTime\":\"22-08-2018 11:00:00\",\"Background\":\"#ff0000\", \"IsAllDay\":\"False\"}," +
            "{\"Subject\": \"Performance Check\",\"StartTime\": \"17-08-2018 17:00:00\",\"EndTime\":\"17-08-2018 18:00:00\",\"Background\":\"#5944dd\", \"IsAllDay\":\"False\"}," +
            "{\"Subject\": \"Consulting\",\"StartTime\": \"03-08-2018 9:00:00\",\"EndTime\":\"03-08-2018 11:00:00\",\"Background\":\"#ed0497\", \"IsAllDay\":\"True\"}," +
            "{\"Subject\": \"Yoga Therapy\",\"StartTime\": \"27-08-2018 10:00:00\",\"EndTime\":\"27-08-2018 11:00:00\",\"Background\":\"#ff0000\", \"IsAllDay\":\"False\"}," +
            "{\"Subject\": \"Project Plan\",\"StartTime\": \"30-08-2018 15:00:00\",\"EndTime\":\"30-08-2018 16:00:00\",\"Background\":\"#ed0497\", \"IsAllDay\":\"False\"} ]";

        public ViewModel()
        {
            Meetings = new ObservableCollection<Meeting>();

            List<JSONData> jsonDataCollection = JsonConvert.DeserializeObject<List<JSONData>>(JsonData);

            foreach (var data in jsonDataCollection)
            {
                Meetings.Add(new Meeting()
                {
                    EventName = data.Subject,
                    From = DateTime.Parse(data.StartTime),
                    To = DateTime.Parse(data.EndTime),
                    Color = Color.FromHex(data.Background),
                    AllDay = Convert.ToBoolean(data.IsAllDay)
                });
            }
        }
    }
}
