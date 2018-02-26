using System.Collections.Generic;

namespace Kinoman.Entities.MultiKino
{
    public partial class Time
    {
        public string SessionId { get; set; }
        public string VersionId { get; set; }
        public string TimeTime { get; set; }
        public string ScreenType { get; set; }
        public object ScreenNumber { get; set; }
        public object Lang { get; set; }
        public List<Tag> Tags { get; set; }
        public object EventInfo { get; set; }
        public bool Hidden { get; set; }
        public System.DateTimeOffset Date { get; set; }
    }
}