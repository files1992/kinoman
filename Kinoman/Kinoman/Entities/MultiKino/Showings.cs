using System.Collections.Generic;
using Kinoman.Entities.Common;
using Newtonsoft.Json;

namespace Kinoman.Entities.MultiKino
{
    public partial class Showings
    {
        public string DatePrefix { get; set; }
        [JsonProperty(PropertyName = "date_day")]
        public string DateDay { get; set; }
        public string DateShort { get; set; }
        public string DateLong { get; set; }
        public System.DateTimeOffset DateTime { get; set; }
        public string DateFormatted { get; set; }
        public List<Time> Times { get; set; }
        public System.DateTimeOffset Date { get; set; }
        public System.DateTimeOffset Cdate { get; set; }
        public bool Clone { get; set; }
    }
}