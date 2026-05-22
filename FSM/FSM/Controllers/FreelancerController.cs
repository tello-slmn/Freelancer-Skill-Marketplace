using FSM.Data;
using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class FreelancerController : Controller
    {
        // CRUD for freelancer profiles, manages skills, review contracts
        private readonly IFreelancerRepository _freelancerRepository;

        public FreelancerController(IFreelancerRepository freelancerRepository)
        {
            _freelancerRepository = freelancerRepository;
        }

        public IActionResult Index()
        {
            return View(_freelancerRepository.AllFreelancers);
        }
    }
}
