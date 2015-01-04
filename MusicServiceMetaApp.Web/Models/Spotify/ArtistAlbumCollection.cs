using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MusicServiceMetaApp.Web.Models.Spotify
{
    [DataContract]
    public class ArtistAlbumCollection
    {
        [DataMember]
        public IEnumerable<Album> Items { get; set; }
    }
}