using System.Runtime.Serialization;

namespace Msma.Integrations.Spotify.Models
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public string Url { get; set; }
    }
}