using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.Wimp.Models
{
    [DataContract]
    public class Tracklist
    {
        [DataMember]
        public IEnumerable<Track> Items { get; set; }

        [DataMember]
        public int TotalNumberOfItems { get; set; }
    }
}