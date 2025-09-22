using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSquads
{
    internal class RandomPhoto
    {
        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }
    }

    class RandomPhotoItem
    {

        public RandomPhotoItem()
        {

        }

        public RandomPhotoItem(string link, string description)
        {
            Link = link;
            Description = description;
        }

        public string Link { get; set; }
        public string Description { get; set; }
    }
}
