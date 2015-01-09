using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class GetAlbumsWrapper
    {
        [DataMember(Name = "code")]
        public string ResponseCode { get; set; }

        [DataMember(Name = "data")]
        public IEnumerable<Album> Albums { get; set; }
    }
}
