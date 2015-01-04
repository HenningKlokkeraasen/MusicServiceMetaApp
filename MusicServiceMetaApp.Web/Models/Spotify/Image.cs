using System.Runtime.Serialization;

namespace MusicServiceMetaApp.Web.Models.Spotify
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public string Url { get; set; }
    }
}