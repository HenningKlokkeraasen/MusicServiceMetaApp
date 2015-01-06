using Msma.Orchestration.Mappings;

namespace MusicServiceMetaApp.Web
{
    public class MappingConfiguration
    {
        public void SetupMappings()
        {
            new SpotifyMappingConfiguration().SetupMappings();
            new WimpMappingConfiguration().SetupMappings();
            new LastFmMappingConfiguration().SetupMappings();
        }
    }
}