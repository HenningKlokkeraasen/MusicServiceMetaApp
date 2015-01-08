using System.Runtime.Serialization;

namespace Msma.Integrations.MusicBrainz.Models
{
    [DataContract]
    public class Release
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Name { get; set; }
        
        [DataMember]
        public string Country { get; set; }
        
        [DataMember]
        public string Status { get; set; }

        [DataMember(Name = "release_date")]
        public string ReleaseDate { get; set; }
    }
}