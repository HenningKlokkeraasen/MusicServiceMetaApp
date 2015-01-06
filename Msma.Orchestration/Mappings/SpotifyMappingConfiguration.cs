using AutoMapper;

namespace Msma.Orchestration.Mappings
{
    public class SpotifyMappingConfiguration
    {
        public void SetupMappings()
        {
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.Artist, Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.Album, Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.Track, Domain.Models.Track>();
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.Tracklist, Domain.Models.Tracklist>();
            Mapper.CreateMap<Msma.Integrations.Spotify.Models.User, Domain.Models.User>();
        }
    }
}