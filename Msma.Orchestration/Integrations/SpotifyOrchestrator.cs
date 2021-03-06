﻿using System.Collections.Generic;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Enums;
using Msma.Domain.Models;
using Msma.Integrations.Spotify;

namespace Msma.Orchestration.Integrations
{
    public class SpotifyOrchestrator : OrchestratorBase
    {
        private readonly SpotifyGateway _gateway = new SpotifyGateway();
        private const SourceEnum Source = SourceEnum.Spotify;

        public ArtistDto GetArtist(string id)
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
                AppearsOn = appearsOn,
                //Compilations = compilations.Items
            };

            return SetSoruce(dto, Source);
        }

        public AlbumDto GetAlbum(string id)
        {
            var albumData = _gateway.FetchAlbum(id);
            var album = Mapper.Map<Album>(albumData);

            AlbumDto dto = new AlbumDto
            {
                Album = album,
                Tracks = Mapper.Map<Tracklist>(albumData.Tracks)
            };

            return SetSoruce(dto, Source);
        }

        public TrackDto GetTrack(string id)
        {
            var track = Mapper.Map<Track>(_gateway.FetchTrack(id));

            var dto = new TrackDto
            {
                Track = track
            };

            return SetSoruce(dto, Source);
        }

        public void GetPlaylist(string id)
        {
            
        }

        public UserDto GetUser(string id)
        {
            var user = Mapper.Map<User>(_gateway.FetchUser(id));

            var dto = new UserDto
            {
                User = user
            };

            return SetSoruce(dto, Source);
        }

    }
}