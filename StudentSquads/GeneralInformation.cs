using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSquads
{
    public class GeneralInformation
    {
        public GeneralInformation() { }

        [JsonProperty("squad")]
        public string id { get; set; }

        [JsonProperty("info")]
        public string information { get; set; }
    }

    public class GeneralInformationItem
    {
        public GeneralInformationItem() { }

        [JsonProperty("squad")]
        public string id { get; set; }

        [JsonProperty("info")]
        public string information { get; set; }
    }
}
