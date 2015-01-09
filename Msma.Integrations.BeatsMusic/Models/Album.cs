using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Msma.Integrations.BeatsMusic.Models
{
    [DataContract]
    public class Album
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Name { get; set; }

        [DataMember(Name = "release_date")]
        public string ReleaseDate { get; set; }

        [DataMember]
        public AlbumRefs Refs { get; set; }
        
        public IEnumerable<ArtistInRefs> Artists
        {
            get { return Refs.Artists; }
        }

        public IEnumerable<Track> Tracks
        {
            get { return Refs.Tracks; }
        }
    }
}
