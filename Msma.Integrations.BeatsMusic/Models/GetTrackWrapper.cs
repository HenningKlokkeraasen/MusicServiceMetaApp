using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class GetTrackWrapper
    {
        [DataMember(Name = "code")]
        public string ResponseCode { get; set; }

        [DataMember(Name = "data")]
        public Track Track { get; set; }
    }
}
