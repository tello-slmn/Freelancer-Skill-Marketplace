using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class AdminController : Controller
    {
        // Manages users, projects, reports
        public IActionResult Index()
        {
            return View();
        }
    }
}
