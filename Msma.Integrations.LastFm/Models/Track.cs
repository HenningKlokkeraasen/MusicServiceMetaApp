using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class Track : TrackBase
    {
        [DataMember]
        public AlbumInTrack Album { get; set; }

        [DataMember(Name = "duration")]
        public int DurationInMilliseconds { get; set; }

        public int DurationInSeconds
        {
            get { return DurationInMilliseconds/1000; }
        }
    }
}