using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Enums;
using Msma.Domain.Models;
using Msma.Integrations.BeatsMusic;

namespace Msma.Orchestration.Integrations
{
    public class BeatsMusicOrchestrator : OrchestratorBase
    {
        private readonly BeatsMusicGateway _gateway;
        private const SourceEnum Source = SourceEnum.BeatsMusic;

        public BeatsMusicOrchestrator(string developerKey)
        {
            _gateway = new BeatsMusicGateway(developerKey);
        }

        public ArtistDto GetArtist(string id)
        {
            var unmappedArtist = _gateway.FetchArtist(id);
            unmappedArtist.ImageUrl = _gateway.FetchArtistImageUrl(id);
            var artist = Mapper.Map<Artist>(unmappedArtist);

            var unmappedAlbums = _gateway.FetchAlbums(id);
            var albums = Mapper.Map<IEnumerable<Album>>(unmappedAlbums);

            var dto = new ArtistDto
            {
                Artist = artist,
                Albums = albums
            };

            return SetSoruce(dto, Source);
        }

        public AlbumDto GetAlbum(string id)
        {
            var unmappedAlbum = _gateway.FetchAlbum(id);
            var album = Mapper.Map<Album>(unmappedAlbum);
            var tracks = Mapper.Map<IEnumerable<Track>>(unmappedAlbum.Tracks);

            var dto = new AlbumDto
            {
                Album = album,
                Tracks = new Tracklist
                {
                    Items = tracks
                }
            };

            return SetSoruce(dto, Source);
        }
    }
}
