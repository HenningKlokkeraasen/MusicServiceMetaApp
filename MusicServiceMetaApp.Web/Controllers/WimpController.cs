using System.Web.Mvc;
using MusicServiceMetaApp.Web.Orchestrators;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class WimpController : Controller
    {
        private readonly WimpOrchestrator _orchestrator = new WimpOrchestrator();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Artist(int id)
        {
            if (id < 0)
                return View("Error");
            
            var artistDto = _orchestrator.GetArtist(id);
            return View(artistDto);
        }

        public ActionResult Album(int id)
        {
            if (id < 0)
                return View("Error");

            var albumDto = _orchestrator.GetAlbum(id);
            return View(albumDto);
        }

        public ActionResult Track(int id)
        {
            if (id < 0)
                return View("Error");

            var trackDto = _orchestrator.GetTrack(id);
            return View(trackDto);
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

        //    var userDto = _orchestrator.GetUser(id);
        //    return View(userDto);
        //}

    }
}