using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class ProposalController : Controller
    {
        // Submit proposals, view proposals per project, update statuses
        public IActionResult Index()
        {
            return View();
        }
    }
}
