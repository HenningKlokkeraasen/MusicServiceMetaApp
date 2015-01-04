using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MusicServiceMetaApp.Web.Models.Spotify
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; }

        [DataMember]
        public IEnumerable<Image> Images { get; set; }
    }
}