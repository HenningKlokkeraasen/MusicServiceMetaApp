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
        public RefsForAlbum Refs { get; set; }

        [DataMember(Name = "release_format")]
        public string ReleaseFormat { get; set; }

        public IEnumerable<ArtistInRefs> Artists
        {
            get { return Refs.Artists; }
        }

        public string ImageUrl { get; set; }

        //public IEnumerable<Track> Tracks
        //{
        //    get { return Refs.Tracks; }
        //}
    }
}
