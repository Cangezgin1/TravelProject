using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelProject.Models.Sınıflar;

namespace TravelProject.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin p)
        {
            var values = c.Admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Kullanici, false);
                Session["Kullanici"] = values.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
                return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }
    }
}