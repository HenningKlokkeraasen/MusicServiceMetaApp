using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class ArtistBio
    {
        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public string YearFormed { get; set; }

        [DataMember]
        public string PlaceFormed { get; set; }
    }
}
