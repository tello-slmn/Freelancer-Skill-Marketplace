using FSM.Models;
using Microsoft.EntityFrameworkCore;

namespace FSM.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            
            #region Freelancers
            if (!context.Freelancers.Any())
            {
                context.AddRange(
                    new Freelancer { FreelancerFName = "Alice", FreelancerLName = "Johnson", FreelancerEmail = "alice.johnson@example.com", FreelancerBio = "Front-end developer specializing in React and UI design." },
                    new Freelancer { FreelancerFName = "Brian", FreelancerLName = "Smith", FreelancerEmail = "brian.smith@example.com", FreelancerBio = "Full-stack engineer with experience in ASP.NET Core and SQL Server." },
                    new Freelancer { FreelancerFName = "Carla", FreelancerLName = "Nguyen", FreelancerEmail = "carla.nguyen@example.com", FreelancerBio = "Data analyst passionate about turning raw data into insights." },
                    new Freelancer { FreelancerFName = "David", FreelancerLName = "Brown", FreelancerEmail = "david.brown@example.com", FreelancerBio = "Mobile app developer focusing on Android and Kotlin." },
                    new Freelancer { FreelancerFName = "Ella", FreelancerLName = "Martinez", FreelancerEmail = "ella.martinez@example.com", FreelancerBio = "UX researcher with a background in psychology and design." },
                    new Freelancer { FreelancerFName = "Felix", FreelancerLName = "Garcia", FreelancerEmail = "felix.garcia@example.com", FreelancerBio = "Cloud solutions architect experienced in Azure and AWS." },
                    new Freelancer { FreelancerFName = "Grace", FreelancerLName = "Lee", FreelancerEmail = "grace.lee@example.com", FreelancerBio = "Content writer specializing in technical documentation." },
                    new Freelancer { FreelancerFName = "Henry", FreelancerLName = "Wilson", FreelancerEmail = "henry.wilson@example.com", FreelancerBio = "Cybersecurity consultant with penetration testing expertise." },
                    new Freelancer { FreelancerFName = "Isabella", FreelancerLName = "Taylor", FreelancerEmail = "isabella.taylor@example.com", FreelancerBio = "Graphic designer skilled in Adobe Creative Suite." },
                    new Freelancer { FreelancerFName = "Jack", FreelancerLName = "Harris", FreelancerEmail = "jack.harris@example.com", FreelancerBio = "Backend developer with strong knowledge of C# and APIs." },
                    new Freelancer { FreelancerFName = "Kylie", FreelancerLName = "Roberts", FreelancerEmail = "kylie.roberts@example.com", FreelancerBio = "SEO specialist helping businesses grow their online presence." },
                    new Freelancer { FreelancerFName = "Liam", FreelancerLName = "Clark", FreelancerEmail = "liam.clark@example.com", FreelancerBio = "Game developer with Unity and C# experience." },
                    new Freelancer { FreelancerFName = "Maya", FreelancerLName = "Lopez", FreelancerEmail = "maya.lopez@example.com", FreelancerBio = "Project manager with Agile and Scrum certifications." },
                    new Freelancer { FreelancerFName = "Noah", FreelancerLName = "Hall", FreelancerEmail = "noah.hall@example.com", FreelancerBio = "AI researcher working on natural language processing." },
                    new Freelancer { FreelancerFName = "Olivia", FreelancerLName = "Allen", FreelancerEmail = "olivia.allen@example.com", FreelancerBio = "Marketing strategist with expertise in digital campaigns." },
                    new Freelancer { FreelancerFName = "Paul", FreelancerLName = "Young", FreelancerEmail = "paul.young@example.com", FreelancerBio = "DevOps engineer automating CI/CD pipelines." },
                    new Freelancer { FreelancerFName = "Quinn", FreelancerLName = "Scott", FreelancerEmail = "quinn.scott@example.com", FreelancerBio = "Copywriter crafting compelling brand stories." },
                    new Freelancer { FreelancerFName = "Rosa", FreelancerLName = "King", FreelancerEmail = "rosa.king@example.com", FreelancerBio = "Data scientist with Python and machine learning skills." },
                    new Freelancer { FreelancerFName = "Sam", FreelancerLName = "Wright", FreelancerEmail = "sam.wright@example.com", FreelancerBio = "IT support specialist with strong troubleshooting skills." },
                    new Freelancer { FreelancerFName = "Tina", FreelancerLName = "Evans", FreelancerEmail = "tina.evans@example.com", FreelancerBio = "Social media manager growing communities online." },
                    new Freelancer { FreelancerFName = "Uma", FreelancerLName = "Hill", FreelancerEmail = "uma.hill@example.com", FreelancerBio = "QA tester ensuring software quality and reliability." },
                    new Freelancer { FreelancerFName = "Victor", FreelancerLName = "Green", FreelancerEmail = "victor.green@example.com", FreelancerBio = "Blockchain developer building decentralized applications." },
                    new Freelancer { FreelancerFName = "Wendy", FreelancerLName = "Adams", FreelancerEmail = "wendy.adams@example.com", FreelancerBio = "Illustrator creating digital art and storyboards." },
                    new Freelancer { FreelancerFName = "Xavier", FreelancerLName = "Nelson", FreelancerEmail = "xavier.nelson@example.com", FreelancerBio = "Systems analyst optimizing enterprise workflows." },
                    new Freelancer { FreelancerFName = "Yara", FreelancerLName = "Bennett", FreelancerEmail = "yara.bennett@example.com", FreelancerBio = "Web developer specializing in responsive design." }
                );
                context.SaveChanges();
            }
            #endregion

            #region Categories
            if (!context.Categories.Any())
            {
                context.AddRange(
                    new Category { CategoryName = "Web Development" },
                    new Category { CategoryName = "Mobile Development" },
                    new Category { CategoryName = "Data Science" },
                    new Category { CategoryName = "Cloud Computing" },
                    new Category { CategoryName = "Cybersecurity" },
                    new Category { CategoryName = "UI/UX Design" },
                    new Category { CategoryName = "Digital Marketing" },
                    new Category { CategoryName = "Game Development" },
                    new Category { CategoryName = "Content Writing" },
                    new Category { CategoryName = "Blockchain" }
                );
                context.SaveChanges();
            }
            #endregion

            #region Skills
            if (!context.Skills.Any())
            {
                context.AddRange(
                    new Skill { SkillName = "C#", CategoryID = 1 },
                    new Skill { SkillName = "ASP.NET Core", CategoryID = 1 },
                    new Skill { SkillName = "HTML/CSS", CategoryID = 1 },
                    new Skill { SkillName = "JavaScript", CategoryID = 1 },
                    new Skill { SkillName = "React", CategoryID = 1 },
                    new Skill { SkillName = "Java", CategoryID = 2 },
                    new Skill { SkillName = "Kotlin", CategoryID = 2 },
                    new Skill { SkillName = "Swift", CategoryID = 2 },
                    new Skill { SkillName = "Python", CategoryID = 3 },
                    new Skill { SkillName = "R", CategoryID = 3 },
                    new Skill { SkillName = "SQL", CategoryID = 3 },
                    new Skill { SkillName = "Machine Learning", CategoryID = 3 },
                    new Skill { SkillName = "AWS", CategoryID = 4 },
                    new Skill { SkillName = "Azure", CategoryID = 4 },
                    new Skill { SkillName = "Penetration Testing", CategoryID = 5 },
                    new Skill { SkillName = "UI Design", CategoryID = 6 },
                    new Skill { SkillName = "UX Research", CategoryID = 6 },
                    new Skill { SkillName = "SEO", CategoryID = 7 },
                    new Skill { SkillName = "Unity", CategoryID = 8 },
                    new Skill { SkillName = "Blockchain Development", CategoryID = 10 }
                );
                context.SaveChanges();
            }
            #endregion

            #region FreelancerSkills
            if (!context.FreelancerSkills.Any())
            {
                context.AddRange(
                    new FreelancerSkill { FreelancerID = 1, SkillID = 5, ProficiencyLevel = "Advanced" },
                    new FreelancerSkill { FreelancerID = 2, SkillID = 2, ProficiencyLevel = "Intermediate" },
                    new FreelancerSkill { FreelancerID = 3, SkillID = 11, ProficiencyLevel = "Advanced" },
                    new FreelancerSkill { FreelancerID = 4, SkillID = 7, ProficiencyLevel = "Intermediate" },
                    new FreelancerSkill { FreelancerID = 5, SkillID = 17, ProficiencyLevel = "Advanced" },
                    new FreelancerSkill { FreelancerID = 6, SkillID = 13, ProficiencyLevel = "Advanced" },
                    new FreelancerSkill { FreelancerID = 7, SkillID = 18, ProficiencyLevel = "Intermediate" },
                    new FreelancerSkill { FreelancerID = 8, SkillID = 15, ProficiencyLevel = "Advanced" },
                    new FreelancerSkill { FreelancerID = 9, SkillID = 16, ProficiencyLevel = "Advanced" },
                    new FreelancerSkill { FreelancerID = 10, SkillID = 1, ProficiencyLevel = "Advanced" }
                );
                context.SaveChanges();
            }
            #endregion

            #region Clients
            if (!context.Clients.Any())
            {
                context.AddRange(
                    new Client { ClientFName = "Alice", ClientLName = "Johnson", ClientEmail = "alice.johnson@techsolutions.com", ClientCompanyName = "Tech Solutions Inc." },
                    new Client { ClientFName = "Brian", ClientLName = "Smith", ClientEmail = "brian.smith@healthcareplus.org", ClientCompanyName = "Healthcare Plus" },
                    new Client { ClientFName = "Catherine", ClientLName = "Lee", ClientEmail = "catherine.lee@edusmart.com", ClientCompanyName = "EduSmart Ltd." },
                    new Client { ClientFName = "David", ClientLName = "Nguyen", ClientEmail = "david.nguyen@retailhub.com", ClientCompanyName = "Retail Hub" },
                    new Client { ClientFName = "Emma", ClientLName = "Brown", ClientEmail = "emma.brown@fintrack.com", ClientCompanyName = "FinTrack Corp." },
                    new Client { ClientFName = "Frank", ClientLName = "Williams", ClientEmail = "frank.williams@logisticspro.com", ClientCompanyName = "Logistics Pro" },
                    new Client { ClientFName = "Grace", ClientLName = "Miller", ClientEmail = "grace.miller@meditech.com", ClientCompanyName = "MediTech" },
                    new Client { ClientFName = "Henry", ClientLName = "Davis", ClientEmail = "henry.davis@greenenergy.com", ClientCompanyName = "Green Energy Ltd." },
                    new Client { ClientFName = "Isabella", ClientLName = "Moore", ClientEmail = "isabella.moore@fashionhub.com", ClientCompanyName = "Fashion Hub" },
                    new Client { ClientFName = "Jack", ClientLName = "Taylor", ClientEmail = "jack.taylor@travelworld.com", ClientCompanyName = "Travel World" }
                );
                context.SaveChanges();
            }
            #endregion
                
            #region Projects
            if (!context.Projects.Any())
            {
                context.AddRange(
                    new Project { ClientID = 1, ProjectTitle = "Inventory Management System", ProjectDescription = "Web-based system to manage warehouse inventory.", ProjectBudget = 15000, ProjectStatus = true, ProjectPostedDate = DateTime.Now.AddDays(-30) },
                    new Project { ClientID = 1, ProjectTitle = "Mobile Banking App", ProjectDescription = "Cross-platform mobile app for secure banking transactions.", ProjectBudget = 25000, ProjectStatus = false, ProjectPostedDate = DateTime.Now.AddDays(-10) },
                    new Project { ClientID = 2, ProjectTitle = "Patient Portal", ProjectDescription = "Portal for patients to access medical records and appointments.", ProjectBudget = 18000, ProjectStatus = true, ProjectPostedDate = DateTime.Now.AddDays(-45) },
                    new Project { ClientID = 2, ProjectTitle = "Telemedicine Platform", ProjectDescription = "Video consultation platform integrated with hospital systems.", ProjectBudget = 30000, ProjectStatus = false, ProjectPostedDate = DateTime.Now.AddDays(-5) },
                    new Project { ClientID = 3, ProjectTitle = "E-Learning Platform", ProjectDescription = "Interactive platform for online courses and assessments.", ProjectBudget = 22000, ProjectStatus = true, ProjectPostedDate = DateTime.Now.AddDays(-60) },
                    new Project { ClientID = 3, ProjectTitle = "Virtual Classroom", ProjectDescription = "Real-time video classroom with whiteboard and chat features.", ProjectBudget = 27000, ProjectStatus = false, ProjectPostedDate = DateTime.Now.AddDays(-15) },
                    new Project { ClientID = 4, ProjectTitle = "E-Commerce Website", ProjectDescription = "Online store with integrated payment gateway.",ProjectBudget = 20000,ProjectStatus = true,ProjectPostedDate = DateTime.Now.AddDays(-20) },
                    new Project { ClientID = 4, ProjectTitle = "Customer Loyalty App", ProjectDescription = "Mobile app for tracking loyalty points and rewards.", ProjectBudget = 12000, ProjectStatus = false, ProjectPostedDate = DateTime.Now.AddDays(-7) },
                    new Project { ClientID = 5, ProjectTitle = "Expense Tracker", ProjectDescription = "Personal finance app to track expenses and savings.", ProjectBudget = 10000, ProjectStatus = true, ProjectPostedDate = DateTime.Now.AddDays(-60) },
                    new Project { ClientID = 5, ProjectTitle = "Investment Portfolio Manager", ProjectDescription = "Web app for managing and analyzing investment portfolios.", ProjectBudget = 25000, ProjectStatus = false, ProjectPostedDate = DateTime.Now.AddDays(-10) }
                );
                context.SaveChanges();
            }
            #endregion

            #region Proposals
            if (!context.Proposals.Any())
            {
                context.AddRange(
                    new Proposal { ProjectID = 1, FreelancerID = 2, ProposalBidAmount = 14000, ProposalMessage = "I can deliver this inventory system in 6 weeks.", ProposalStatus = true },
                    new Proposal { ProjectID = 2, FreelancerID = 4, ProposalBidAmount = 23000, ProposalMessage = "Experienced in mobile banking apps, ready to start.", ProposalStatus = false },
                    new Proposal { ProjectID = 3, FreelancerID = 3, ProposalBidAmount = 17500, ProposalMessage = "Strong background in healthcare portals.", ProposalStatus = true },
                    new Proposal { ProjectID = 4, FreelancerID = 6, ProposalBidAmount = 28000, ProposalMessage = "Cloud integration and telemedicine expertise.", ProposalStatus = false },
                    new Proposal { ProjectID = 5, FreelancerID = 9, ProposalBidAmount = 21000, ProposalMessage = "Interactive e-learning design with responsive UI.", ProposalStatus = true },
                    new Proposal { ProjectID = 6, FreelancerID = 1, ProposalBidAmount = 26000, ProposalMessage = "React-based virtual classroom with real-time features.", ProposalStatus = false },
                    new Proposal { ProjectID = 7, FreelancerID = 10, ProposalBidAmount = 19000, ProposalMessage = "Backend developer with e-commerce experience.", ProposalStatus = true },
                    new Proposal { ProjectID = 8, FreelancerID = 7, ProposalBidAmount = 11000, ProposalMessage = "SEO and loyalty app integration.", ProposalStatus = false },
                    new Proposal { ProjectID = 9, FreelancerID = 5, ProposalBidAmount = 9500, ProposalMessage = "UX-focused expense tracker app.", ProposalStatus = true },
                    new Proposal { ProjectID = 10, FreelancerID = 14, ProposalBidAmount = 15000, ProposalMessage = "AI researcher offering smart investment dashboard.", ProposalStatus = false }
                );
                context.SaveChanges();
            }
            #endregion

            #region Contracts
            if (!context.Contracts.Any())
            {
                context.AddRange(
                    new Contract { ProposalID = 1, ContractStartDate = DateTime.Now.AddDays(-25), ContractEndDate = DateTime.Now.AddDays(20), ContractTerms = "Deliver inventory system in 6 weeks." },
                    new Contract { ProposalID = 3, ContractStartDate = DateTime.Now.AddDays(-40), ContractEndDate = DateTime.Now.AddDays(10), ContractTerms = "Healthcare portal with secure login." },
                    new Contract { ProposalID = 5, ContractStartDate = DateTime.Now.AddDays(-55), ContractEndDate = DateTime.Now.AddDays(5), ContractTerms = "E-learning platform with assessments." },
                    new Contract { ProposalID = 7, ContractStartDate = DateTime.Now.AddDays(-18), ContractEndDate = DateTime.Now.AddDays(30), ContractTerms = "E-commerce site with payment gateway." },
                    new Contract { ProposalID = 9, ContractStartDate = DateTime.Now.AddDays(-22), ContractEndDate = DateTime.Now.AddDays(15), ContractTerms = "Expense tracker with reporting features." },
                    new Contract { ProposalID = 10, ContractStartDate = DateTime.Now.AddDays(-12), ContractEndDate = DateTime.Now.AddDays(40), ContractTerms = "Investment dashboard with AI insights." },
                    new Contract { ProposalID = 2, ContractStartDate = DateTime.Now.AddDays(-8), ContractEndDate = DateTime.Now.AddDays(60), ContractTerms = "Mobile banking app with secure transactions." },
                    new Contract { ProposalID = 4, ContractStartDate = DateTime.Now.AddDays(-5), ContractEndDate = DateTime.Now.AddDays(50), ContractTerms = "Telemedicine platform with cloud integration." },
                    new Contract { ProposalID = 6, ContractStartDate = DateTime.Now.AddDays(-15), ContractEndDate = DateTime.Now.AddDays(35), ContractTerms = "Virtual classroom with real-time chat." },
                    new Contract { ProposalID = 8, ContractStartDate = DateTime.Now.AddDays(-7), ContractEndDate = DateTime.Now.AddDays(25), ContractTerms = "Customer loyalty app with SEO features." }
                );
                context.SaveChanges();
            }
            #endregion
        }
    }
}