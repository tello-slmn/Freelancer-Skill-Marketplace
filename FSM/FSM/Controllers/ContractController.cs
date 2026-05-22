using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class ContractController : Controller
    {
        // Create contracts from accepted proposals, track progress, mark complete
        public IActionResult Index()
        {
            return View();
        }
    }
}
