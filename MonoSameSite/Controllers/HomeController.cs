using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonoSameSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SetCookie();
            return View();
        }

        private void SetCookie()
        {
            var cookie = new HttpCookie("SampleCookie", "Hello World")
            {
                Expires = DateTime.Now.AddMinutes(1),
                Secure = true,
                SameSite = SameSiteMode.None
            };
            Response.Cookies.Add(cookie);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}