using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Msma.Integrations.Spotify.Models
{
    [DataContract]
    public class Artist
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public IEnumerable<Image> Images { get; set; }

        public string ImageUrl
        {
            get
            {
                return Images != null && Images.Any()
                    ? Images.ToArray()[2].Url
                    : string.Empty;
            }
        }
    }
}