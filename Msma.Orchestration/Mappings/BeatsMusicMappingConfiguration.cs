using AutoMapper;

namespace Msma.Orchestration.Mappings
{
    public class BeatsMusicMappingConfiguration
    {
        public void SetupMappings()
        {
            Mapper.CreateMap<Msma.Integrations.BeatsMusic.Models.Artist, Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.BeatsMusic.Models.ArtistInRefs, Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.BeatsMusic.Models.Album, Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.BeatsMusic.Models.Track, Domain.Models.Track>();
        }
    }
}
