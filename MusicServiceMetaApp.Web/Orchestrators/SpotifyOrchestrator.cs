using System.Collections.Generic;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Models;
using Msma.Integrations.Spotify;

namespace MusicServiceMetaApp.Web.Orchestrators
{
    public class SpotifyOrchestrator
    {
        private readonly SpotifyGateway _gateway = new SpotifyGateway();

        public ArtistDto GetArtist(string id)
        {
            var artist = Mapper.Map<Artist>(_gateway.FetchArtist(id));
            var albums = Mapper.Map<IEnumerable<Album>>(_gateway.FetchArtistAlbums(id));
            var singles = Mapper.Map<IEnumerable<Album>>(_gateway.FetchArtistSingles(id));
            var appearsOn = Mapper.Map<IEnumerable<Album>>(_gateway.FetchArtistAppearsOn(id));

            ArtistDto artistDto = new ArtistDto
            {
                Artist = artist,
                Albums = albums,
                Singles = singles,
                AppearsOn = appearsOn,
                //Compilations = compilations.Items
            };

            return artistDto;
        }

        public AlbumDto GetAlbum(string id)
        {
            var albumData = _gateway.FetchAlbum(id);
            var album = Mapper.Map<Album>(albumData);

            AlbumDto albumDto = new AlbumDto
            {
                Album = album,
                Tracks = Mapper.Map<Tracklist>(albumData.Tracks)
            };

            return albumDto;
        }

        public TrackDto GetTrack(string id)
        {
            var track = Mapper.Map<Track>(_gateway.FetchTrack(id));

            var trackDto = new TrackDto
            {
                Track = track
            };

            return trackDto;
        }

        public void GetPlaylist(string id)
        {
            
        }

        public UserDto GetUser(string id)
        {
            var user = Mapper.Map<User>(_gateway.FetchUser(id));

            var userDto = new UserDto
            {
                User = user
            };

            return userDto;
        }

    }
}