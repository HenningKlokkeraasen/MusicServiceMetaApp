using System.Web.Mvc;
using MusicServiceMetaApp.Web.Data;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class MusicBrainzController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = MusicBrainzIndexData.GetViewModel();
            return View(viewModel);
        }
    }
}