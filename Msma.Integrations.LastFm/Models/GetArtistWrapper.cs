using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class GetArtistWrapper
    {
        [DataMember]
        public Artist Artist { get; set; }
    }
}
