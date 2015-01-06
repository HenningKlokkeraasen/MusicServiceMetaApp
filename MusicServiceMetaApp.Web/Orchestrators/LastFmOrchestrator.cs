using System.Collections.Generic;
using System.Configuration;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Enums;
using Msma.Domain.Models;
using Msma.Integrations.LastFm;

namespace MusicServiceMetaApp.Web.Orchestrators
{
    internal class LastFmOrchestrator : OrchestratroBase
    {
        private readonly LastFmGateway _gateway = new LastFmGateway(ConfigurationManager.AppSettings["LastFmDeveloperKey"]);
        private const SourceEnum Source = SourceEnum.LastFm;

        internal ArtistDto GetArtist(string artistName)
        {
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

        internal AlbumDto GetAlbum(string albumName, string artistName)
        {
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

        public TrackDto GetTrack(string trackName, string artistName)
        {
            var track = Mapper.Map<Track>(_gateway.FetchTrack(trackName, artistName));

            var dto = new TrackDto
            {
                Track = track
            };

            return SetSoruce(dto, Source);
        }
    }
}