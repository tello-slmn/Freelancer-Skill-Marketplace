namespace FSM.Models
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public Level SkillLevel { get; set; }

        //User
    }

    public enum Level
    {
        Beginner,
        Intermediate,
        Advanced,
        Expert
    }
}
