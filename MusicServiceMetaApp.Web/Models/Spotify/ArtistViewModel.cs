using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MusicServiceMetaApp.Web.Models.Spotify
{
    [DataContract]
    public class ArtistViewModel
    {
        [DataMember]
        public Artist Artist { get; set; }

        [DataMember]
        public IEnumerable<Album> Albums { get; set; }

        [DataMember]
        public IEnumerable<Album> Singles { get; set; }

        [DataMember]
        public IEnumerable<Album> AppearsOn { get; set; }

        [DataMember]
        public IEnumerable<Album> Compilations { get; set; }
    }
}