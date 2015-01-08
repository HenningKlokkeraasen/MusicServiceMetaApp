using System.Collections.Generic;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Enums;
using Msma.Domain.Models;
using Msma.Integrations.MusicBrainz;

namespace Msma.Orchestration.Integrations
{
    public class MusicBrainsOrchestrator : OrchestratorBase
    {
        private readonly MusicBrainzGateway _gateway = new MusicBrainzGateway();
        private const SourceEnum Source = SourceEnum.MusicBrainz;

        public ArtistDto GetArtist(string mbid)
        {
            var unmappedArtist = _gateway.FetchArtist(mbid);
            var artist = Mapper.Map<Artist>(unmappedArtist);
            var bio = new ArtistBio
            {
                YearFormed = unmappedArtist.LifeSpan.Begin,
                PlaceFormed = unmappedArtist.BeginArea.Name
            };
            var topAlbums = Mapper.Map<IEnumerable<Album>>(unmappedArtist.ReleaseGroups);

            var dto = new ArtistDto
            {
                Artist = artist,
                Bio = bio,
                TopAlbums = topAlbums
            };

            return SetSoruce(dto, Source);
        }

        public AlbumDto GetAlbum(string mbid)
        {
            var unmappedAlbum = _gateway.FetchReleaseGroup(mbid);
            var album = Mapper.Map<Album>(unmappedAlbum);

            var dto = new AlbumDto
            {
                Album = album,
                Tracks = new Tracklist
                {
                    Items = new List<Track>()
                }
            };

            return SetSoruce(dto, Source);
        }
    }
}
