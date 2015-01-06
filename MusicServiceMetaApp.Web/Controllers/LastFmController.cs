using System.Web.Mvc;
using Msma.Integrations.LastFm;
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

            var name = LastFmIdHelper.ConvertIdToName(id);

            var viewModel = _orchestrator.GetArtist(name);
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

            var identificationParameters = LastFmIdHelper.ConvertIdToNames(id);
            if (identificationParameters == null)
                return View("Error");

            var artistName = identificationParameters.Item1;
            var trackName = identificationParameters.Item2;

            var viewModel = _orchestrator.GetAlbum(trackName, artistName);
            return View(viewModel);
        }

        public ActionResult Track(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            var identificationParameters = LastFmIdHelper.ConvertIdToNames(id);
            if (identificationParameters == null)
                return View("Error");

            var artistName = identificationParameters.Item1;
            var trackName = identificationParameters.Item2;

            var viewModel = _orchestrator.GetTrack(trackName, artistName);
            return View(viewModel);
        }
    }
}