using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class GetTrackWrapper
    {
        [DataMember]
        public Track Track { get; set; }
    }
}
