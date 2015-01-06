using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class AlbumInTopAlbums : AlbumBase
    {
        [DataMember]
        public Artist Artist { get; set; }

        public IEnumerable<Artist> Artists
        {
            get
            {
                return new List<Artist>
                {
                    Artist
                };
            }
        }
    }
}
