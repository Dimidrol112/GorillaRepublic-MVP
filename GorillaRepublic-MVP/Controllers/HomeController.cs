using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace GorillaRepublic_MVP.Controllers
{
    public class HomeController : Controller
    {
        public int test = 0;
        public ActionResult Index()
        {
            MyData.Process();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application." + MyData.data;

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

    public static class MyData
    {
        public static int data = 0;
        public static Thread th = null;

        public static void Process()
        {
            if (th == null)
            {
                var th = new Thread(Game);
                th.Start();
            }
        }

        public static void Game()
        {
            while (true)
            {
                data++;
                Thread.Sleep(100);
            }
        }
    }
}
