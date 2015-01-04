using System;
using System.Configuration;
using System.Web.Mvc;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string setting = Environment.GetEnvironmentVariable("MSMA.TestKey");
            if (string.IsNullOrEmpty(setting))
                setting = ConfigurationManager.AppSettings["MSMA.TestKey"];
            ViewBag.ConfigValue = setting;

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