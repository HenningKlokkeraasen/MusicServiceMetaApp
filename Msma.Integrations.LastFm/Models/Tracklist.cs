using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class Tracklist
    {
        [DataMember(Name = "track")]
        public IEnumerable<TrackInTracklist> Items { get; set; }
    }
}