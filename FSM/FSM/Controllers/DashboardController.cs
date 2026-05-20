using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
