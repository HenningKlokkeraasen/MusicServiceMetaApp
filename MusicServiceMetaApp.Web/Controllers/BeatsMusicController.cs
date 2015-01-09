using System.Configuration;
using System.Web.Mvc;
using Msma.Orchestration.Integrations;
using MusicServiceMetaApp.Web.Data;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class BeatsMusicController : Controller
    {
        private readonly BeatsMusicOrchestrator _orchestrator = new BeatsMusicOrchestrator(ConfigurationManager.AppSettings["BeatsMusicDeveloperKey"]);

        public ActionResult Index()
        {
            var viewModel = BeatsMusicIndexData.GetViewModel();
            return View(viewModel);
        }

        public ActionResult Artist(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetArtist(id);
            return View(viewModel);
        }

        public ActionResult Album(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetAlbum(id);
            return View(viewModel);
        }
    }
}