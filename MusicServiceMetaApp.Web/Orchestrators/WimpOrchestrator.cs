using System.Collections.Generic;
using System.Configuration;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Models;
using Msma.Integrations.Wimp;

namespace MusicServiceMetaApp.Web.Orchestrators
{
    internal class WimpOrchestrator : OrchestratroBase
    {
        private readonly WimpGateway _gateway = new WimpGateway(ConfigurationManager.AppSettings["WimpDeveloperKey"]);
        private const string SourceName = "WiMP";

        internal ArtistDto GetArtist(int id)
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

            return SetSoruce(dto, SourceName);
        }

        internal AlbumDto GetAlbum(int id)
        {
            var album = Mapper.Map<Album>(_gateway.FetchAlbum(id));
            var tracks = Mapper.Map<Tracklist>(_gateway.FetchTracklist(id));

            AlbumDto dto = new AlbumDto
            {
                Album = album,
                Tracks = tracks
            };

            return SetSoruce(dto, SourceName);
        }

        internal TrackDto GetTrack(int id)
        {
            var track = Mapper.Map<Track>(_gateway.FetchTrack(id));

            var dto = new TrackDto
            {
                Track = track
            };

            return SetSoruce(dto, SourceName);
        }

        internal void GetPlaylist(int id)
        {

        }

        //internal UserDto GetUser(int id)
        //{
            
        //}

    }
}