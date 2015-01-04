using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicServiceMetaApp.Web.Startup))]
namespace MusicServiceMetaApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
