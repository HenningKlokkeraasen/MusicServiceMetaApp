using System.Runtime.Serialization;

namespace Msma.Integrations.MusicBrainz.Models
{
    [DataContract]
    public class Area
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Id { get; set; }
    }
}