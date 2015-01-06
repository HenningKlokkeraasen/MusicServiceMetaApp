using AutoMapper;

namespace MusicServiceMetaApp.Web
{
    public class MappingConfiguration
    {
        public void SetupMappings()
        {
            SetupSpotifyMappings();
            SetupWimpMappings();
            SetupLastFmMappings();
        }

        private static void SetupWimpMappings()
        {
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Artist, Msma.Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Album, Msma.Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Track, Msma.Domain.Models.Track>();
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Tracklist, Msma.Domain.Models.Tracklist>();
        }

        private static void SetupSpotifyMappings()
        {
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.Artist, Msma.Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.Album, Msma.Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.Track, Msma.Domain.Models.Track>();
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.Tracklist, Msma.Domain.Models.Tracklist>();
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.User, Msma.Domain.Models.User>();
        }

        private static void SetupLastFmMappings()
        {
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.Artist, Msma.Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.Album, Msma.Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.AlbumInTopAlbums, Msma.Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.AlbumInTrack, Msma.Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.Track, Msma.Domain.Models.Track>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.TrackInTracklist, Msma.Domain.Models.Track>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.Tracklist, Msma.Domain.Models.Tracklist>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.ArtistBio, Msma.Domain.Models.ArtistBio>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.AlbumInfo, Msma.Domain.Models.AlbumInfo>();
        }
    }
}