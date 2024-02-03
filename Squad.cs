using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace StudentSquads
{
    public record Squad(
        [property: JsonProperty("squad_id")] string Id,
        [property: JsonProperty("squad_name")] string Name,
        [property: JsonProperty("squad_icon_absolute_link")] string SquadIconAbsoluteLink,
        [property: JsonProperty("squad_icon_file")] string SquadIconFile);
    
}
