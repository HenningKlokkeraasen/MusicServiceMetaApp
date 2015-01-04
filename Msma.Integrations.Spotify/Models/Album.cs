using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Msma.Integrations.Spotify.Models
{
    [DataContract]
    public class Album
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public IEnumerable<Artist> Artists { get; set; }
        
        [DataMember(Name = "release_date")]
        public string ReleaseDate { get; set; }

        [DataMember]
        public IEnumerable<Image> Images { get; set; }

        [DataMember]
        public Tracklist Tracks { get; set; }

        public string ImageUrl
        {
            get
            {
                return Images != null && Images.Any()
                    ? Images.ToArray()[1].Url
                    : string.Empty;
            }
        }
    }
}