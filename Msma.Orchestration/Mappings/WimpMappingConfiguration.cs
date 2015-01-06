using AutoMapper;

namespace Msma.Orchestration.Mappings
{
    public class WimpMappingConfiguration
    {
        public void SetupMappings()
        {
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Artist, Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Album, Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Track, Domain.Models.Track>();
            Mapper.CreateMap<Msma.Integrations.Wimp.Models.Tracklist, Domain.Models.Tracklist>();
        }
    }
}