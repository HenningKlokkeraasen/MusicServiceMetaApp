using System.Runtime.Serialization;

namespace Msma.Integrations.MusicBrainz.Models
{
    [DataContract]
    public class LifeSpan
    {
        [DataMember]
        public string Begin { get; set; }

        [DataMember]
        public string End { get; set; }

        [DataMember]
        public bool Ended { get; set; }
    }
}