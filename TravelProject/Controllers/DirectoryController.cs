using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelProject.Controllers
{
    public class DirectoryController : Controller
    {

        public ActionResult Hotels()
        {
            return View();
        }

        public ActionResult Restaurants()
        {
            return View();
        }

        public ActionResult Museums()
        {
            return View();
        }

    }
}