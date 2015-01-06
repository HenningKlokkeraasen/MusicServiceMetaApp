using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public abstract class TrackBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public string LastFmId { get; set; }

        [DataMember(Name = "mbid")]
        public string MusicBrainzId { get; set; }

        [DataMember]
        public Artist Artist { get; set; }

        [DataMember]
        public Album Album { get; set; }

        public string Id
        {
            get { return MusicBrainzId; }
        }

        public IEnumerable<Artist> Artists
        {
            get
            {
                return new List<Artist>
                {
                    Artist
                };
            }
        }
    }
}
