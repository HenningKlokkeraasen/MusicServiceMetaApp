using System.Collections.Generic;
using Msma.Domain.Models;

namespace Msma.Domain.Dtos
{
    public class ArtistDto : DtoBase
    {
        public Artist Artist { get; set; }

        public IEnumerable<Album> Albums
        {
            get { return _albums; }
            set { _albums = value; }
        }

        public IEnumerable<Album> Singles
        {
            get { return _singles; }
            set { _singles = value; }
        }

        public IEnumerable<Album> AppearsOn
        {
            get { return _appearsOn; }
            set { _appearsOn = value; }
        }

        public IEnumerable<Album> Compilations
        {
            get { return _compilations; }
            set { _compilations = value; }
        }

        public IEnumerable<Album> TopAlbums
        {
            get { return _topAlbums; }
            set { _topAlbums = value; }
        }

        public ArtistBio Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        private ArtistBio _bio = new ArtistBio();
        private IEnumerable<Album> _albums = new List<Album>();
        private IEnumerable<Album> _singles = new List<Album>();
        private IEnumerable<Album> _appearsOn = new List<Album>();
        private IEnumerable<Album> _topAlbums = new List<Album>();
        private IEnumerable<Album> _compilations = new List<Album>();
    }
}
