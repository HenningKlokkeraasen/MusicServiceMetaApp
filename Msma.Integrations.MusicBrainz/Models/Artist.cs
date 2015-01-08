using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.MusicBrainz.Models
{
    [DataContract]
    public class Artist
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember(Name = "life-span")]
        public LifeSpan LifeSpan { get; set; }

        [DataMember(Name = "begin_area")]
        public Area BeginArea { get; set; }

        [DataMember(Name = "release-groups")]
        public IEnumerable<ReleaseGroup> ReleaseGroups
        {
            get { return _releaseGroups; }
            set { _releaseGroups = value; }
        }

        [DataMember]
        public IEnumerable<Release> Releases
        {
            get { return _releases; }
            set { _releases = value; }
        }

        private IEnumerable<Release> _releases = new List<Release>();
        private IEnumerable<ReleaseGroup> _releaseGroups = new List<ReleaseGroup>();
    }
}
