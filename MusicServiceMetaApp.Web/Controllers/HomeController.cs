using System.Configuration;
using System.Web.Mvc;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ConfigValue = ConfigurationManager.AppSettings["MSMA.TestKey"];

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Music Service Meta App";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Music Service Meta App";

            return View();
        }
    }
}