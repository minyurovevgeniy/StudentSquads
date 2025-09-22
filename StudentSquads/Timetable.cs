using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSquads
{
    internal class Timetable
    {
        public Timetable() { }

        [JsonProperty("squad")]
        public string squad { get; set; }

        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("weekday")]
        public string weekday { get; set; }
        
        [JsonProperty("start_time")]
        public string start_time { get; set; }
        
        [JsonProperty("end_time")]
        public string end_time { get; set; }
        
        [JsonProperty("is_cancelled")]
        public string is_cancelled { get; set; }
        
    }

    class TimetableItem
    {
        public string Date { get; set; }
        public string Weekday { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string IsCancelled { get; set; }

        public TimetableItem()
        {

        }

        public TimetableItem(string date,string weekday, string start_time, string end_time, string is_cancelled)
        {
            Date = date;
            Weekday = weekday;
            StartTime = start_time;
            EndTime = end_time;
            IsCancelled = is_cancelled;
        }
    }
}
