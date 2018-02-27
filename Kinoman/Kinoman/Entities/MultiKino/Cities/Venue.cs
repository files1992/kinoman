using System.Collections.Generic;

namespace Kinoman.Entities.MultiKino.Cities
{
    public partial class Venue
    {
        public string Alpha { get; set; }
        public bool Hidden { get; set; }
        public List<Cinema> Cinemas { get; set; }
    }
}