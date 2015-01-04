using Msma.Domain.Models;

namespace Msma.Domain.Dtos
{
    public class AlbumDto
    {
        public Album Album { get; set; }

        public Tracklist Tracks { get; set; }
    }
}
