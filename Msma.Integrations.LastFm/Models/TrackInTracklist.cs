using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class TrackInTracklist : TrackBase
    {
        [DataMember(Name = "duration")]
        public int DurationInSeconds { get; set; }

        [DataMember(Name = "@attr")]
        public AttributesWrapper Attributes { get; set; }

        public int TrackNumber
        {
            get { return Attributes.TrackNumber; }
        }
    }

    [DataContract]
    public class AttributesWrapper
    {
        [DataMember(Name = "rank")]
        public int TrackNumber { get; set; }
    }
}
