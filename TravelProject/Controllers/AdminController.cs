using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Sınıflar;

namespace TravelProject.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context(); // Veri tabanımızdan verileri cekebilmek için Context sınıfımızdan nesne türettik.

        public ActionResult Index()
        {
            var values = c.Blogs.ToList(); // Ana sayfada Blog tablomuzdan verileri listeledik.
            return View(values);
        }


        #region Yeni BLOG EKLEME 

        // Sayfayı her yenilediğimizde veri eklenmesin diye Get ve Post methodu kullandık.

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View(); // Sayfayı göstermek için
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p) // Blog tablosundan p parametresi yaptık verileri taşıyabilelim diye.
        {
            c.Blogs.Add(p); // Blog tablosuna verilerimizi ekledik
            c.SaveChanges(); // Güncelledik.
            return RedirectToAction("Index"); // Ve son olarak Index sayfamıza yönlendirdik.
        }

        #endregion

        #region Blog SİLME

        public ActionResult BlogSil(int id) // id değeri aldık çünkü silebileceğimiz veriyi bulmak için.
        {
            var values = c.Blogs.Find(id); // İd'den gelen değerin tablodaki karşılığını bulduk.
            c.Blogs.Remove(values); // Ve veriyi Remove meyhodu ile sildik.
            c.SaveChanges(); // Güncelledik
            return RedirectToAction("Index"); // Ve son olarak Index sayfasına yönlendirdik.
        }

        #endregion

        #region BLOG GÜNCELLEME

        public ActionResult BlogGetir(int id) // İd'ye göre verilerimizi getireceğiz.
        {
            var values = c.Blogs.Find(id); // Aldığımız id tablodan hangi idyele eşleşiyor buluyoruz.
            return View("BlogGetir",values); // Ve Values değeriyle bilikte BlogGetir sayfasına gidiyoruz.
        }

        public ActionResult BlogGüncelle(Blog p) // Blogtan parametre türetip içine değerleri atıyoruz
        {
            var values = c.Blogs.Find(p.ID); // Idmize karşılık gelen ıd'yi buluyoruz.
            values.Aciklama = p.Aciklama;
            values.Baslik = p.Baslik;
            values.BlogImage = p.BlogImage;
            values.Tarih = p.Tarih;
            c.SaveChanges(); // Kaydetip yönlendiriyoruz.
            return RedirectToAction("Index");
        }
        #endregion
    }
}