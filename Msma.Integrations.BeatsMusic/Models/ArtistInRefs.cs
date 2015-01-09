using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class ArtistInRefs
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name = "display")]
        public string Name { get; set; }
    }
}
