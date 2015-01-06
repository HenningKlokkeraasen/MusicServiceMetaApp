using System.Collections.Generic;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Enums;
using Msma.Domain.Models;
using Msma.Integrations.LastFm;

namespace Msma.Orchestration.Integrations
{
    public class LastFmOrchestrator : OrchestratorBase
    {
        private readonly LastFmGateway _gateway;
        private const SourceEnum Source = SourceEnum.LastFm;

        public LastFmOrchestrator(string developerKey)
        {
            _gateway = new LastFmGateway(developerKey);
        }

        public ArtistDto GetArtist(string id)
        {
            var artistName = LastFmIdHelper.ConvertIdToName(id);

            var unmappedArtist = _gateway.FetchArtist(artistName);
            var artist = Mapper.Map<Artist>(unmappedArtist);
            var topAlbums = Mapper.Map<IEnumerable<Album>>(_gateway.FetchTopAlbums(artistName));
            var bio = Mapper.Map<ArtistBio>(unmappedArtist.Bio);

            var dto = new ArtistDto
            {
                Artist = artist,
                TopAlbums = topAlbums,
                Bio = bio
            };

            return SetSoruce(dto, Source);
        }

        //public ArtistDto GetArtistByName(string name)
        //{
        //    var unmappedArtist = _gateway.FetchArtistByName(name);
        //    var artist = Mapper.Map<Artist>(unmappedArtist);
        //    var topAlbums = Mapper.Map<IEnumerable<Album>>(_gateway.FetchTopAlbums(unmappedArtist.MusicBrainzId));
        //    var bio = Mapper.Map<ArtistBio>(unmappedArtist.Bio);

        //    var dto = new ArtistDto
        //    {
        //        Artist = artist,
        //        TopAlbums = topAlbums,
        //        Bio = bio
        //    };

        //    return SetSoruce(dto, Source);
        //}

        public AlbumDto GetAlbum(string id)
        {
            var identificationParameters = LastFmIdHelper.ConvertIdToNames(id);
            if (identificationParameters == null)
                return null;

            var artistName = identificationParameters.Item1;
            var albumName = identificationParameters.Item2;

            var unmappedAlbum = _gateway.FetchAlbum(albumName, artistName);
            unmappedAlbum.Artist = _gateway.FetchArtist(artistName);
            var album = Mapper.Map<Album>(unmappedAlbum);
            var tracks = Mapper.Map<Tracklist>(unmappedAlbum.Tracks);

            var dto = new AlbumDto
            {
                Album = album,
                Tracks = tracks
            };

            return SetSoruce(dto, Source);
        }

        public TrackDto GetTrack(string id)
        {
            var identificationParameters = LastFmIdHelper.ConvertIdToNames(id);
            if (identificationParameters == null)
                return null;

            var artistName = identificationParameters.Item1;
            var trackName = identificationParameters.Item2;

            var track = Mapper.Map<Track>(_gateway.FetchTrack(trackName, artistName));

            var dto = new TrackDto
            {
                Track = track
            };

            return SetSoruce(dto, Source);
        }
    }
}