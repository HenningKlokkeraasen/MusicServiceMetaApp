using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Msma.Integrations.Spotify.Models
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; }

        [DataMember]
        public IEnumerable<Image> Images { get; set; }

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