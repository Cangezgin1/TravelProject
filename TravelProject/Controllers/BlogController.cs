using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Sınıflar;

namespace TravelProject.Controllers
{
    public class BlogController : Controller
    {

        Context c = new Context(); // Veritabanından veri cekmek için oluşturuldu.

        BlogYorum by = new BlogYorum(); // Aynı tablodan 2 farklı veri çekilecekse burdan çekiyoruz.


        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList(); // Blog tablosunu listeliyoruz.
            by.Deger2 = c.Yorumlars.OrderByDescending(x => x.ID).Take(5).Distinct();
            by.Deger3 = c.Blogs.OrderByDescending(x=>x.ID).Take(5).Distinct(); // Blog tablosundan ilk 5 veriyi getiriyoruz(tekrar edenler hariç yani iki farklı veri( Distinict() ) )
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList(); // İndexs sayfasından müşteri hangi ıdye tıkadıysa o ıd'ye ait Blog detay sayfasını listeliyoruz.
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList(); // Yukardakiyle aynı şekilde aldığımız id ye ait yorumları listeliyoruz.
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(5).Distinct(); // Blog tablosundan 5 adet farklı veri alıyoruz.
            return View(by);
        }


        #region Yorum Yapma 

        [HttpGet]
        public PartialViewResult YorumYap(int id) // Yorum yapacağımız blogun ıd'sini alıyoruz burda
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y) // Yorumlardan parametre türetip değerleri ona atıyoruz.
        {
            c.Yorumlars.Add(y); // Ekleme
            c.SaveChanges(); // Yüklüyoruz
            return PartialView(); 
        }

        #endregion
    }
}