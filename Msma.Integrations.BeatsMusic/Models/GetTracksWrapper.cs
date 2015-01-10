using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class GetTracksWrapper
    {
        [DataMember(Name = "code")]
        public string ResponseCode { get; set; }

        [DataMember(Name = "data")]
        public IEnumerable<Track> Tracks { get; set; }
    }
}
