using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kinoman.Entities.MultiKino
{
    public partial class PromoLabels
    {
        [JsonProperty(PropertyName = "names")]
        public List<PromoLabelsName> Names { get; set; }
        public string Position { get; set; }
        public bool Isborder { get; set; }
    }
}