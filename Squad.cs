using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace StudentSquads
{
    public record Squad(
        [property: JsonPropertyName("squad_name")] string Name,
        [property: JsonPropertyName("squad_id")] int Id,
        [property: JsonPropertyName("squad_icon_absolute_link")] string squadIconAbsoluteLink);
    
}
