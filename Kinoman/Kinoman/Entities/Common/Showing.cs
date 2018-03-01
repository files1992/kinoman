using System;

namespace Kinoman.Entities.Common
{
    public class Showing
    {
        public Movie Movie { get; set; }
        public CinemaInfo CinemaInfo { get; set; }
        public DateTime BeginsAt { get; set; }
        public bool IsPremeire { get; set; }
    }
}