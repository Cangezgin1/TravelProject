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

        BlogYorum by = new BlogYorum(); // Aynı tablodan 2 farklı veri çekilecekse burdan çekiyoruz.

        public ActionResult Index()
        {
            var values = c.Blogs.Take(6).ToList(); // Blog tablosundan 4 veri listeliyoruz.
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
         
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList(); // Blog tablosundan veriyi cekiyoruz.
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            by.Deger1 = c.Blogs.Take(3).ToList(); // Blog tablosundan 3 adet veri cekiyoruz.
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList(); // Blog tablosundan ıd'si en büyük 3 veriyi cekiyoruz.
            return PartialView(by);
        }
    }
}