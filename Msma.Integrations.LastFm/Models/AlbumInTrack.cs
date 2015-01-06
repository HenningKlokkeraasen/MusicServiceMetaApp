using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class AlbumInTrack : Album
    {
        [DataMember(Name = "title")]
        public new string Name { get; set; }

        public new string Id
        {
            get { return LastFmIdHelper.ConvertNamesToId(ArtistName, Name); }
        }
    }
}