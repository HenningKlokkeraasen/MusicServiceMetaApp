using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class GetTopAlbumsWrapper
    {
        [DataMember(Name = "topalbums")]
        public TopAlbumsInnerWrapper TopAlbumsInnerWrapper { get; set; }
    }

    [DataContract]
    public class TopAlbumsInnerWrapper
    {
        [DataMember(Name = "album")]
        public IEnumerable<AlbumInTopAlbums> Albums { get; set; }
    }
}
