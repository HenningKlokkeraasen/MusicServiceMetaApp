using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class AlbumInfo
    {
        [DataMember]
        public string Summary { get; set; }
    }
}
