using System.Collections.Generic;

namespace Dapper.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string TrackTitle { get; set; }
        public string Duration { get; set; }
        public string Isrc { get; set; }
        public bool Controlled { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<TrackComposer> Composers { get; set; }
    }
}