using Microsoft.AspNetCore.Mvc;

namespace _32923.Controllers
{
    public class HomeController:Controller
    {
        public  ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

    }
}
