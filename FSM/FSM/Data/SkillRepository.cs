using FSM.Models;

namespace FSM.Data
{
    public class SkillRepository : ISkillRepository
    {
        public IEnumerable<Skill> AllSkills =>
        [
            new Skill { SkillID = 1, SkillName = "C#", CategoryID = 1 },
            new Skill { SkillID = 2, SkillName = "ASP.NET Core", CategoryID = 1 },
            new Skill { SkillID = 3, SkillName = "HTML/CSS", CategoryID = 1 },
            new Skill { SkillID = 4, SkillName = "JavaScript", CategoryID = 1 },
            new Skill { SkillID = 5, SkillName = "React", CategoryID = 1 },
            new Skill { SkillID = 6, SkillName = "Java", CategoryID = 2 },
            new Skill { SkillID = 7, SkillName = "Kotlin", CategoryID = 2 },
            new Skill { SkillID = 8, SkillName = "Swift", CategoryID = 2 },
            new Skill { SkillID = 9, SkillName = "Python", CategoryID = 3 },
            new Skill { SkillID = 10, SkillName = "R", CategoryID = 3 },
            new Skill { SkillID = 11, SkillName = "SQL", CategoryID = 3 },
            new Skill { SkillID = 12, SkillName = "Machine Learning", CategoryID = 3 },
            new Skill { SkillID = 13, SkillName = "Penetration Testing", CategoryID = 4 },
            new Skill { SkillID = 14, SkillName = "Network Security", CategoryID = 4 },
            new Skill { SkillID = 15, SkillName = "AWS", CategoryID = 5 },
            new Skill { SkillID = 16, SkillName = "Azure", CategoryID = 5 },
            new Skill { SkillID = 17, SkillName = "Docker", CategoryID = 5 },
            new Skill { SkillID = 18, SkillName = "Kubernetes", CategoryID = 5 },
            new Skill { SkillID = 19, SkillName = "TensorFlow", CategoryID = 3 },
            new Skill { SkillID = 20, SkillName = "Angular", CategoryID = 1 },
            new Skill { SkillID = 21, SkillName = "Vue.js", CategoryID = 1 },
            new Skill { SkillID = 22, SkillName = "PHP", CategoryID = 1 },
            new Skill { SkillID = 23, SkillName = "Ruby on Rails", CategoryID = 1 },
            new Skill { SkillID = 24, SkillName = "Go", CategoryID = 2 },
            new Skill { SkillID = 25, SkillName = "Flutter", CategoryID = 2 }
        ];

        public Skill GetSkillById(int skillId) => AllSkills.FirstOrDefault(s => s.SkillID == skillId);
    }
}
