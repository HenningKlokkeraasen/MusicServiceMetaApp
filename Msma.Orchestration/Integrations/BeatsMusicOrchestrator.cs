﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

            var unmappedToAlbums = _gateway.FetchEssentialAlbums(id);
            unmappedToAlbums.Each(a => a.ImageUrl = _gateway.FetchAlbumImageUrl(a.Id));
            var topAlbums = Mapper.Map<IEnumerable<Album>>(unmappedToAlbums);

            var unmappedAlbums = _gateway.FetchAlbums(id);
            unmappedAlbums.Each(a => a.ImageUrl = _gateway.FetchAlbumImageUrl(a.Id));
            var albums = Mapper.Map<IEnumerable<Album>>(unmappedAlbums.Where(a => a.ReleaseFormat == "LP"));
            var singles = Mapper.Map<IEnumerable<Album>>(unmappedAlbums.Where(a => a.ReleaseFormat == "EP" || a.ReleaseFormat == "Single"));
            var compilations = Mapper.Map<IEnumerable<Album>>(unmappedAlbums.Where(a => a.ReleaseFormat == "Compilation"));

            var unmappedAppearsOn = _gateway.FetchAppearsOnAlbums(id, unmappedAlbums.Select(a => a.Id));
            unmappedAppearsOn.Each(a => a.ImageUrl = _gateway.FetchAlbumImageUrl(a.Id));
            var appearsOn = Mapper.Map<IEnumerable<Album>>(unmappedAppearsOn);

            var dto = new ArtistDto
            {
                Artist = artist,
                Albums = albums,
                Singles = singles,
                Compilations = compilations,
                AppearsOn = appearsOn,
                TopAlbums = topAlbums
            };

            return SetSoruce(dto, Source);
        }

        public AlbumDto GetAlbum(string id)
        {
            var unmappedAlbum = _gateway.FetchAlbum(id);
            unmappedAlbum.ImageUrl = _gateway.FetchAlbumImageUrl(id);
            var album = Mapper.Map<Album>(unmappedAlbum);
            var tracks = Mapper.Map<IEnumerable<Track>>(_gateway.FetchTracks(id));

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

        public TrackDto GetTrack(string id)
        {
            var unmappedTrack = _gateway.FetchTrack(id);
            var track = Mapper.Map<Track>(unmappedTrack);
            track.Album.ImageUrl = _gateway.FetchAlbumImageUrl(unmappedTrack.Album.Id);

            var dto = new TrackDto
            {
                Track = track
            };

            return SetSoruce(dto, Source);
        }

    }
}
