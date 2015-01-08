using System.Runtime.Serialization;

namespace Msma.Integrations.MusicBrainz.Models
{
    [DataContract]
    public class ArtistCredit
    {
        [DataMember]
        public Artist Artist { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string JoinPhrase { get; set; }
    }
}
