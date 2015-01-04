using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.Wimp.Models
{
    [DataContract]
    public class ArtistAlbumCollection
    {
        [DataMember]
        public IEnumerable<Album> Items { get; set; }

        [DataMember]
        public int TotalNumberOfItems { get; set; }
    }
}