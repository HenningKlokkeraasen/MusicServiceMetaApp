using System.Collections.Generic;

namespace Msma.Domain.Models
{
    public class Album
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Artist> Artists { get; set; }
        
        public string ReleaseDate { get; set; }

        public string ImageUrl { get; set; }

        public AlbumInfo AlbumInfo { get; set; }
    }
}