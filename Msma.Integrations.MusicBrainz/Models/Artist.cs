using System.Runtime.Serialization;

namespace Msma.Integrations.MusicBrainz.Models
{
    [DataContract]
    public class Artist
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember(Name = "life-span")]
        public LifeSpan LifeSpan { get; set; }

        [DataMember(Name = "begin_area")]
        public Area BeginArea { get; set; }
    }
}
