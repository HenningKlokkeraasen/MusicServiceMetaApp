using System.Web.Mvc;
using MusicServiceMetaApp.Web.Orchestrators;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class SpotifyController : Controller
    {
        private readonly SpotifyOrchestrator _orchestrator = new SpotifyOrchestrator();

        public ActionResult Index()
        {
            return View();
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

        public ActionResult Track(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetTrack(id);
            return View(viewModel);
        }

        public ActionResult Playlist(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            return View();
        }

        public ActionResult User(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetUser(id);
            return View(viewModel);
        }

    }
}