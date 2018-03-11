using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kinoman.Entities.MultiKino
{
    public partial class Film
    {
        public long OriginalSCount { get; set; }
        public long Sortable { get; set; }
        public List<Showings> Showings { get; set; }
        public bool ShowShowings { get; set; }
        public string FilmPageName { get; set; }
        public string Title { get; set; }
        public string Id { get; set; }
        public string ImageHero { get; set; }
        public string ImagePoster { get; set; }
        public string CertImage { get; set; }
        public object CertDesc { get; set; }
        [JsonProperty(PropertyName = "synopsis_short")]
        public string SynopsisShort { get; set; }
        public string InfoRelease { get; set; }
        public bool InfoRunningtimeVisible { get; set; }
        [JsonProperty(PropertyName = "info_runningtime")]
        public string InfoRunningtime { get; set; }
        public string InfoAge { get; set; }
        public string PegiClass { get; set; }
        public string InfoDirector { get; set; }
        public object InfoCast { get; set; }
        public string Availablecopy { get; set; }
        public string Videolink { get; set; }
        public string Filmlink { get; set; }
        public string Timeslink { get; set; }
        public string Video { get; set; }
        public bool Hidden { get; set; }
        public bool ComingSoon { get; set; }
        public bool CommingSoon { get; set; }
        public bool Announcement { get; set; }
        public bool VirtualReality { get; set; }
        public Categories Genres { get; set; }
        public Categories Tags { get; set; }
        public Categories Categories { get; set; }
        public ShowingType ShowingType { get; set; }
        public string RankVotes { get; set; }
        public string RankValue { get; set; }
        [JsonProperty(PropertyName = "promo_labels")]
        public PromoLabels PromoLabels { get; set; }
        public System.DateTimeOffset ReleaseDate { get; set; }
        public string Type { get; set; }
        public string Wantsee { get; set; }
        public bool Showwantsee { get; set; }
        public string Newsletterurl { get; set; }
        public bool AlwaysInQb { get; set; }
    }
}