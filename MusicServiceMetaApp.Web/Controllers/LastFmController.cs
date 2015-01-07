using System.Configuration;
using System.Web.Mvc;
using Msma.Orchestration.Integrations;
using MusicServiceMetaApp.Web.Data;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class LastFmController : Controller
    {
        private readonly LastFmOrchestrator _orchestrator = new LastFmOrchestrator(ConfigurationManager.AppSettings["LastFmDeveloperKey"]);
        
        public ActionResult Index()
        {
            var viewModel = LastFmIndexData.GetViewModel();
            return View(viewModel);
        }

        public ActionResult Artist(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetArtist(id);
            return View(viewModel);
        }

        //public ActionResult ArtistByName(string id)
        //{
        //    if (string.IsNullOrEmpty(id))
        //        return View("Error");

        //    var viewModel = _orchestrator.GetArtistByName(id);
        //    return View("Artist", viewModel);
        //}

        public ActionResult Album(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetAlbum(id);

            if (viewModel == null)
                return View("Error");

            return View(viewModel);
        }

        public ActionResult Track(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetTrack(id);

            if (viewModel == null)
                return View("Error");

            return View(viewModel);
        }
    }
}