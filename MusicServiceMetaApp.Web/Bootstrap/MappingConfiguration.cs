using Msma.Orchestration.Mappings;

namespace MusicServiceMetaApp.Web.Bootstrap
{
    public class MappingConfiguration
    {
        public void SetupMappings()
        {
            new SpotifyMappingConfiguration().SetupMappings();
            new WimpMappingConfiguration().SetupMappings();
            new LastFmMappingConfiguration().SetupMappings();
            new MusicBrainzMappingConfiguration().SetupMappings();
        }
    }
}