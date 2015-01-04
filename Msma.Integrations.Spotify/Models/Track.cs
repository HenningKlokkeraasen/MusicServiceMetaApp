using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.Spotify.Models
{
    [DataContract]
    public class Track
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember(Name = "track_number")]
        public int TrackNumber { get; set; }

        [DataMember(Name = "duration_ms")]
        public int Duration { get; set; }

        [DataMember]
        public IEnumerable<Artist> Artists { get; set; }

        [DataMember(Name="preview_url")]
        public string PreviewUrl { get; set; }

        [DataMember]
        public Album Album { get; set; }

        public int DurationInSeconds 
        {
            get { return (int)Math.Round(Duration/100d); }
        }
    }
}