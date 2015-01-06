using System.Web.Mvc;
using MusicServiceMetaApp.Web.Orchestrators;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class LastFmController : Controller
    {
        private readonly LastFmOrchestrator _orchestrator = new LastFmOrchestrator();
        
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
            return View(viewModel);
        }

        public ActionResult Track(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var viewModel = _orchestrator.GetTrack(id);
            return View(viewModel);
        }
    }
}