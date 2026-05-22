namespace FSM.Models
{
    public class FreelancerSkill
    {
        public int FreelancerID { get; set; }
        public int SkillID { get; set; }
        public string ProficiencyLevel { get; set; }

        public Freelancer Freelancer { get; set; }
        public Skill Skill { get; set; }
    }
}
