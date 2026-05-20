namespace FSM.Models
{
    public class DB
    {
        public static List<Skill> GetSkills()
        {
            List<Skill> skills =
            [
                #region Skills
                new Skill
                {
                    SkillID = 1,
                    SkillName = "ASP.NET Core Development",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 2,
                    SkillName = "React.js Frontend",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 3,
                    SkillName = "SQL Database Design",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 4,
                    SkillName = "Python Data Analysis",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 5,
                    SkillName = "Cybersecurity Auditing",
                    SkillLevel = Level.Expert
                },
                new Skill
                {
                    SkillID = 6,
                    SkillName = "AWS Cloud Deployment",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 7,
                    SkillName = "UI/UX Design",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 8,
                    SkillName = "Graphic Design (Photoshop)",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 9,
                    SkillName = "Video Editing (Premiere Pro)",
                    SkillLevel = Level.Beginner
                },
                new Skill
                {
                    SkillID = 10,
                    SkillName = "Content Writing (SEO)",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 11,
                    SkillName = "Project Management (Agile)",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 12,
                    SkillName = "Digital Marketing",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 13,
                    SkillName = "Bookkeeping & Accounting",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 14,
                    SkillName = "Sales & Lead Generation",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 15,
                    SkillName = "Business Consulting",
                    SkillLevel = Level.Expert
                },
                new Skill
                {
                    SkillID = 16,
                    SkillName = "Language Translation (Spanish-English)",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 17,
                    SkillName = "Tutoring (Mathematics)",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 18,
                    SkillName = "Virtual Assistance",
                    SkillLevel = Level.Beginner
                },
                new Skill
                {
                    SkillID = 19,
                    SkillName = "Customer Support",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 20,
                    SkillName = "Resume Writing",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 21,
                    SkillName = "Flutter Mobile Development",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 22,
                    SkillName = "Machine Learning (TensorFlow)",
                    SkillLevel = Level.Advanced
                },
                new Skill
                {
                    SkillID = 23,
                    SkillName = "Penetration Testing",
                    SkillLevel = Level.Expert
                },
                new Skill
                {
                    SkillID = 24,
                    SkillName = "Data Visualization (Power BI)",
                    SkillLevel = Level.Intermediate
                },
                new Skill
                {
                    SkillID = 25,
                    SkillName = "Technical Writing",
                    SkillLevel = Level.Advanced
                }

                #endregion
            ];
            return skills;
        }

        public static Skill GetSkill(int id)
        {
            var skills = GetSkills();
            foreach (Skill s in skills)
            {
                if (s.SkillID == id)
                {
                    return s;
                }
            }
            return new Skill(); // return empty Skill if not in list
        }
    }
}
