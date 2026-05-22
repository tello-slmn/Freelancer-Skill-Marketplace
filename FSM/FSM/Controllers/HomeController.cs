using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class HomeController : Controller
    {
        // Handles homepage, about, public browsing of projects/freelancers
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
