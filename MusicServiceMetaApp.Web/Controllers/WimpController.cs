using System.Configuration;
using System.Web.Mvc;
using Msma.Orchestration.Integrations;
using MusicServiceMetaApp.Web.Data;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class WimpController : Controller
    {
        private readonly WimpOrchestrator _orchestrator = new WimpOrchestrator(ConfigurationManager.AppSettings["WimpDeveloperKey"]);

        public ActionResult Index()
        {
            var viewModel = WimpIndexData.GetViewModel();
            return View(viewModel);
        }

        public ActionResult Artist(int id)
        {
            if (id < 0)
                return View("Error");

            var viewModel = _orchestrator.GetArtist(id);
            return View(viewModel);
        }

        public ActionResult Album(int id)
        {
            if (id < 0)
                return View("Error");

            var viewModel = _orchestrator.GetAlbum(id);
            return View(viewModel);
        }

        public ActionResult Track(int id)
        {
            if (id < 0)
                return View("Error");

            var viewModel = _orchestrator.GetTrack(id);
            return View(viewModel);
        }

        public ActionResult Playlist(int id)
        {
            if (id < 0)
                return View("Error");

            return View();
        }

        //public ActionResult User(int id)
        //{
        //    if (id < 0)
        //        return View("Error");

        //    var viewModel = _orchestrator.GetUser(id);
        //    return View(viewModel);
        //}

    }
}