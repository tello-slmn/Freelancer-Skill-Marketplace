using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class ReviewController : Controller
    {
        // Handle ratings/comments after contract completion
        public IActionResult Index()
        {
            return View();
        }
    }
}
