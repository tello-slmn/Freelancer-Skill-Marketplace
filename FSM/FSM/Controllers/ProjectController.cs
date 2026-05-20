using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
