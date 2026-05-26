namespace FSM.Models
{
    public class FreelancerSkill
    {
        public int FreelancerSkillID { get; set; }
        public int FreelancerID { get; set; }
        public int SkillID { get; set; }
        public string ProficiencyLevel { get; set; } // Beginner, Intermediate, Advanced, Expert, Master

        public Freelancer Freelancer { get; set; }
        public Skill Skill { get; set; }
    }
}
