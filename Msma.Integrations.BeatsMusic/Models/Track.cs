using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class Track
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Name { get; set; }

        [DataMember(Name = "track_position")]
        public int TrackNumber { get; set; }

        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        [DataMember]
        public RefsForTrack Refs { get; set; }

        public IEnumerable<ArtistInRefs> Artists
        {
            get { return Refs.Artists; }
        }

        public AlbumInRefs Album
        {
            get { return Refs.Album; }
        }

        public int DurationInSeconds
        {
            get { return Duration; }
        }
    }
}