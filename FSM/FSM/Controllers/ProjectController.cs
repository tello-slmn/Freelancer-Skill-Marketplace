using FSM.Data;
using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class ProjectController : Controller
    {
        // CRUD for projects, list projects, filter/search, link to proposals/contracts
        private readonly IProjectRepository _projectRepository;

        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public IActionResult Index()
        {
            return View(_projectRepository.AllProjects);
        }
    }
}
