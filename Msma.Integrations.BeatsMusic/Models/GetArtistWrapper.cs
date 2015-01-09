using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class GetArtistWrapper
    {
        [DataMember(Name = "code")]
        public string ResponseCode { get; set; }

        [DataMember(Name = "data")]
        public Artist Artist { get; set; }
    }
}
