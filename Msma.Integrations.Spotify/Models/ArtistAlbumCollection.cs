using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.Spotify.Models
{
    [DataContract]
    public class ArtistAlbumCollection
    {
        [DataMember]
        public IEnumerable<Album> Items { get; set; }
    }
}