using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Sınıflar;

namespace TravelProject.Controllers
{
    public class AnaController : Controller
    {

        Context c = new Context();

        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
    }
}