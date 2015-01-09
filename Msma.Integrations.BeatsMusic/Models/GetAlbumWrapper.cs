using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class GetAlbumWrapper
    {
        [DataMember(Name = "code")]
        public string ResponseCode { get; set; }

        [DataMember(Name = "data")]
        public Album Album { get; set; }
    }
}
