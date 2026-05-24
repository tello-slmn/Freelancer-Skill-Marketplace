using System.ComponentModel.DataAnnotations;

namespace FSM.Models
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
