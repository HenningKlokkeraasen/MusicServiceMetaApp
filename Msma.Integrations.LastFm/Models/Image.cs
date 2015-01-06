using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class Image
    {
        [DataMember(Name = "#text")]
        public string Url { get; set; }

        [DataMember]
        public string Size { get; set; }
    }
}
