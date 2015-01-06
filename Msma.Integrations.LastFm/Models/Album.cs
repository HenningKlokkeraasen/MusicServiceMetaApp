using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class Album : AlbumBase
    {
        [DataMember(Name = "id")]
        public int LastFmId { get; set; }

        [DataMember(Name = "artist")]
        public string ArtistName { get; set; }

        [DataMember]
        public string ReleaseDate { get; set; }

        [DataMember]
        public Tracklist Tracks { get; set; }

        [DataMember(Name = "wiki")]
        public AlbumInfo AlbumInfo { get; set; }

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