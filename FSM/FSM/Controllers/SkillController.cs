using FSM.Models;
using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class SkillController : Controller
    {
        // CRUD for skills, assign/remove skills to freelancers
        public IActionResult Index()
        {
            return View();
        }
    }
}
