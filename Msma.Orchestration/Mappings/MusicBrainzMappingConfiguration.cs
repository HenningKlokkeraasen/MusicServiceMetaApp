using AutoMapper;

namespace Msma.Orchestration.Mappings
{
    public class MusicBrainzMappingConfiguration
    {
        public void SetupMappings()
        {
            Mapper.CreateMap<Msma.Integrations.MusicBrainz.Models.Artist, Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.MusicBrainz.Models.Release, Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.MusicBrainz.Models.ReleaseGroup, Domain.Models.Album>();
        }
    }
}
