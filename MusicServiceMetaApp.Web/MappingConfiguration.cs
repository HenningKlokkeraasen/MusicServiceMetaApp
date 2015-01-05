using System.Collections.Generic;
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
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Album, Msma.Domain.Models.Album>()
                .ForMember(destination => destination.Artists, options => options.MapFrom(source => AddToNewList(source.Artist)));
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Track, Msma.Domain.Models.Track>()
                .ForMember(destination => destination.Artists, options => options.MapFrom(source => AddToNewList(source.Artist)));
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
        }

        private static IEnumerable<Msma.Domain.Models.Artist> AddToNewList(Msma.Integrations.Wimp.Models.Artist artist)
        {
            return new List<Msma.Domain.Models.Artist>
            {
                Mapper.Map<Msma.Domain.Models.Artist>(artist)
            };
        }
    }
}