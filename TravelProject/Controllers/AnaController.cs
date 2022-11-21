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

        Context c = new Context(); // Veritabanımızdan veri çekebilmemiz için Context sınıfımızı tanımlıyoruz.

        public ActionResult Index()
        {
            var values = c.Blogs.ToList(); // Blog tablosunu listeliyoruz.
            return View(values);
        }

        public PartialViewResult Partial1()
        {
            var values = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList(); // Blog tablomuzdan büyükten kücüğe 2(Take methodu) adet veri listeliyoruz.
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var values = c.Blogs.Where(x => x.ID == 1).ToList(); // Blog tablosundan Id=1 olan veriyi cekiyoruz.
            return PartialView(values);
        }

    }
}