using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSquads
{
    internal class Announcement
    {
        public Announcement() { }
        
        [JsonProperty("squad")]
        public string id { get; set; }

        [JsonProperty("announcement_id")]
        public string announcement_id { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    class AnnouncementItem
    {
        public string Time { get; set; }
        public string AnnouncementText { get; set; }

        public AnnouncementItem()
        {

        }

        public AnnouncementItem(string time,string text)
        {
            Time = time;
            AnnouncementText = text;
        }
    }
}
