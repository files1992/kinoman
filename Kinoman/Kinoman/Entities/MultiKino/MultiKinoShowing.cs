using System.Collections.Generic;

namespace Kinoman.Entities.MultiKino
{
    public partial class MultiKinoShowing
    {
        public List<Film> Films { get; set; }
        public string Cdate { get; set; }
        public string SiteRootPath { get; set; }
        public string Site { get; set; }
        public string Lang { get; set; }
    }
}