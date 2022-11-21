using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Sınıflar;

namespace TravelProject.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context(); // Veritabanımızdan veri çekebilmemiz için Context sınıfımızı tanımlıyoruz.

        public ActionResult Index()
        {
            var values = c.Hakkimizdas.ToList(); // Hakkımızda Tablosunu Listeliyoruz.
            return View(values);
        }
    }
}