using System.Collections.Generic;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Enums;
using Msma.Domain.Models;
using Msma.Integrations.Wimp;

namespace Msma.Orchestration.Integrations
{
    public class WimpOrchestrator : OrchestratorBase
    {
        private readonly WimpGateway _gateway;
        private const SourceEnum Source = SourceEnum.Wimp;

        public WimpOrchestrator(string developerKey)
        {
            _gateway = new WimpGateway(developerKey);
        }

        public ArtistDto GetArtist(int id)
        {
            var artist = Mapper.Map<Artist>(_gateway.FetchArtist(id));
            var albums = Mapper.Map<IEnumerable<Album>>(_gateway.FetchArtistAlbums(id));
            var singles = Mapper.Map<IEnumerable<Album>>(_gateway.FetchArtistSingles(id));
            var appearsOn = Mapper.Map<IEnumerable<Album>>(_gateway.FetchArtistAppearsOn(id));

            ArtistDto dto = new ArtistDto
            {
                Artist = artist,
                Albums = albums,
                Singles = singles,
                AppearsOn = appearsOn
            };

            return SetSoruce(dto, Source);
        }

        public AlbumDto GetAlbum(int id)
        {
            var album = Mapper.Map<Album>(_gateway.FetchAlbum(id));
            var tracks = Mapper.Map<Tracklist>(_gateway.FetchTracklist(id));

            AlbumDto dto = new AlbumDto
            {
                Album = album,
                Tracks = tracks
            };

            return SetSoruce(dto, Source);
        }

        public TrackDto GetTrack(int id)
        {
            var track = Mapper.Map<Track>(_gateway.FetchTrack(id));

            var dto = new TrackDto
            {
                Track = track
            };

            return SetSoruce(dto, Source);
        }

        public void GetPlaylist(int id)
        {

        }

        //public UserDto GetUser(int id)
        //{
            
        //}

    }
}