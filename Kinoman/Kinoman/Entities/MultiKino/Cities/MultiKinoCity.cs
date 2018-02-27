using System.Collections.Generic;

namespace Kinoman.Entities.MultiKino.Cities
{
    public partial class MultiKinoCity
    {
        public List<object> Favourites { get; set; }
        public List<Venue> Venues { get; set; }
    }
}