using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.MusicBrainz.Models
{
    [DataContract]
    public class ReleaseGroup
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Name { get; set; }

        [DataMember(Name = "first-release-date")]
        public string ReleaseDate { get; set; }

        [DataMember(Name = "primary-type")]
        public string PrimaryType { get; set; }

        [DataMember(Name = "secondary-types")]
        public IEnumerable<string> SecondaryTypes { get; set; }
    }
}
