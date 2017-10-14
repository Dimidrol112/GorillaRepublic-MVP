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
            ViewBag.Message = "food:" + MyData.food + "| people:" + MyData.peoples;

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
        public static int food = 0;
        public static int peoples = 0;
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
                food += 5;
                peoples++;
                Thread.Sleep(1000);
            }
        }
    }
}
