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

        internal ArtistDto GetArtist(string mbid)
        {
            var unmappedArtist = _gateway.FetchArtist(mbid);
            var artist = Mapper.Map<Artist>(unmappedArtist);
            var topAlbums = Mapper.Map<IEnumerable<Album>>(_gateway.FetchTopAlbums(mbid));
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

        internal AlbumDto GetAlbum(string mbid)
        {
            var unmappedAlbum = _gateway.FetchAlbum(mbid);
            unmappedAlbum.Artist = _gateway.FetchArtistByName(unmappedAlbum.ArtistName);
            var album = Mapper.Map<Album>(unmappedAlbum);
            var tracks = Mapper.Map<Tracklist>(unmappedAlbum.Tracks);

            var dto = new AlbumDto
            {
                Album = album,
                Tracks = tracks
            };

            return SetSoruce(dto, Source);
        }

        public TrackDto GetTrack(string mbid)
        {
            var track = Mapper.Map<Track>(_gateway.FetchTrack(mbid));

            var dto = new TrackDto
            {
                Track = track
            };

            return SetSoruce(dto, Source);
        }
    }
}