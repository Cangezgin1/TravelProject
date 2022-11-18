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

        Context c = new Context();

        BlogYorum by = new BlogYorum();


        public ActionResult Index()
        {
            // var values = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(2).Distinct();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            // var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            by.Deger3 = c.Blogs.Take(2);
            return View(by);
        }
    }
}