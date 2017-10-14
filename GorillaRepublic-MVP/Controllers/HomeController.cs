using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GorillaRepublic_MVP.Controllers
{
    public class HomeController : Controller
    {
        public int test = 0;
        public ActionResult Index()
        {
            test++;
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application." + test;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
