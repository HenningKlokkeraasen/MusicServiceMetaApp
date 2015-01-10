using System.Collections.Generic;

using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class RefsForTrack
    {
        [DataMember]
        public IEnumerable<ArtistInRefs> Artists { get; set; }

        [DataMember]
        public AlbumInRefs Album { get; set; }
    }
}
