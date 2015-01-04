using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.Spotify.Models
{
    [DataContract]
    public class Tracklist
    {
        [DataMember]
        public IEnumerable<Track> Items { get; set; }
    }
}