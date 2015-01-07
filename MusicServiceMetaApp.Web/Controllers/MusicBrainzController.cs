using System.Web.Mvc;
using Msma.Orchestration.Integrations;
using MusicServiceMetaApp.Web.Data;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class MusicBrainzController : Controller
    {
        private readonly MusicBrainsOrchestrator _orchestrator = new MusicBrainsOrchestrator();

        public ActionResult Index()
        {
            var viewModel = MusicBrainzIndexData.GetViewModel();
            return View(viewModel);
        }

        public ActionResult Artist(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetArtist(id);
            return View(viewModel);
        }
    }
}