using System.Collections.Generic;

using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class RefsForAlbum
    {
        [DataMember]
        public IEnumerable<ArtistInRefs> Artists { get; set; }

        [DataMember]
        public Label Label { get; set; }

        //[DataMember]
        //public IEnumerable<Track> Tracks { get; set; }
    }
}
