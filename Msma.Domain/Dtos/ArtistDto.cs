using System.Collections.Generic;
using Msma.Domain.Models;

namespace Msma.Domain.Dtos
{
    public class ArtistDto : DtoBase
    {
        public Artist Artist { get; set; }
        
        public IEnumerable<Album> Albums { get; set; }

        public IEnumerable<Album> Singles { get; set; }

        public IEnumerable<Album> AppearsOn { get; set; }

        //public IEnumerable<Album> Compilations { get; set; }
    }
}
