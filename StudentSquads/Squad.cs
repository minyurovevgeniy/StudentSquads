using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace StudentSquads
{
    class Squad
    {
        [JsonProperty("squad_id")]
        public int id { get; set; }
        
        [JsonProperty("squad_name")]
        public string Name { get; set; }

        [JsonProperty("squad_icon_absolute_link")]
        public string logo { get; set; }

        
        [JsonProperty("squad_icon_file")]
        public string file { get; set; }
    }

    class SquadItem
    {

        public SquadItem()
        {

        }

        public SquadItem(string name, string logo, int id)
        {
            Name = name;
            Logo = logo;
            Id = id;
        }

        public string Name { get; set; }
        public string Logo { get; set; }
        public int Id { get; set; }
    }
}
