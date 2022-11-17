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

        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        BlogYorum by = new BlogYorum();

        public ActionResult BlogDetay(int id)
        {
            // var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
    }
}