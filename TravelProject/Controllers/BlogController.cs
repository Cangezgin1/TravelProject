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
            by.Deger3 = c.Blogs.Take(2).Distinct(); // Blog tablosundan ilk 2 veriyi getiriyoruz(tekrar edenler hariç yani iki farklı veri( Distinict() ) )
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList(); // İndexs sayfasından müşteri hangi ıdye tıkadıysa o ıd'ye ait Blog detay sayfasını listeliyoruz.
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList(); // Yukardakiyle aynı şekilde aldığımız id ye ait yorumları listeliyoruz.
            by.Deger3 = c.Blogs.Take(2); // Blog tablosundan 2 adet farklı veri alıyoruz.
            return View(by);
        }
    }
}