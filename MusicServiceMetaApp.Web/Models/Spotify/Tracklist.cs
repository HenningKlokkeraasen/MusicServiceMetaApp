using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MusicServiceMetaApp.Web.Models.Spotify
{
    [DataContract]
    public class Tracklist
    {
        [DataMember]
        public IEnumerable<Track> Items { get; set; }
    }
}