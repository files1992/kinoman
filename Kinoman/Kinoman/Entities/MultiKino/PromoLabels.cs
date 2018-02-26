using System.Collections.Generic;

namespace Kinoman.Entities.MultiKino
{
    public partial class PromoLabels
    {
        public List<PromoLabelsName> Names { get; set; }
        public string Position { get; set; }
        public bool Isborder { get; set; }
    }
}