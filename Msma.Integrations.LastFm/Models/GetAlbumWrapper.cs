using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class GetAlbumWrapper
    {
        [DataMember]
        public Album Album { get; set; }
    }
}
