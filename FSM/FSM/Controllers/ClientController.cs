using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class ClientController : Controller
    {
        // CRUD for client profiles, manage posted projects
        public IActionResult Index()
        {
            return View();
        }
    }
}
