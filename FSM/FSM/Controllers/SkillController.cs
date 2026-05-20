using FSM.Models;
using Microsoft.AspNetCore.Mvc;

namespace FSM.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Details(int id)
        {
            var skill = DB.GetSkill(id);
            return View(skill);
        }

        public IActionResult Index()
        {
            var skills = DB.GetSkills();
            return View(skills);
        }
    }
}
