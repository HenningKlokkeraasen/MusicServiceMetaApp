using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Msma.Integrations.MusicBrainz.Models
{
    [DataContract]
    public class ReleaseGroup
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Name { get; set; }

        [DataMember(Name = "first-release-date")]
        public string ReleaseDate { get; set; }

        [DataMember(Name = "primary-type")]
        public string PrimaryType { get; set; }

        [DataMember(Name = "secondary-types")]
        public IEnumerable<string> SecondaryTypes { get; set; }

        [DataMember]
        public IEnumerable<Release> Releases
        {
            get { return _releases; }
            set { _releases = value; }
        }

        [DataMember(Name = "artist-credit")]
        public IEnumerable<ArtistCredit> CreditedArtists
        {
            get { return _creditedArtists; }
            set { _creditedArtists = value; }
        }

        public IEnumerable<Artist> Artists
        {
            get { return CreditedArtists.Select(ca => ca.Artist); }
        }

        private IEnumerable<ArtistCredit> _creditedArtists = new List<ArtistCredit>();
        private IEnumerable<Release> _releases = new List<Release>();
    }
}
