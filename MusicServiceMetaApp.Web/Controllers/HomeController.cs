using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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