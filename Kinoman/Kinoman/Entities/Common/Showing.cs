using System;

namespace Kinoman.Entities.Common
{
    public class Showing
    {
        public Movie Movie { get; set; }
        public CinemaInfo CinemaInfo { get; set; }
        public string Date { get; set; }
        public string BeginsAt { get; set; }
        public string IsPremeire { get; set; }
    }
}