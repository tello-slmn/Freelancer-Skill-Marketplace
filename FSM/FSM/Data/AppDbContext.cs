using FSM.Models;
using Microsoft.EntityFrameworkCore;
namespace FSM.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Freelancer> Freelancers { get; set; }
        //public DbSet<Skill> Skills { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        //public DbSet<Proposal> Proposals { get; set; }
        //public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            #region Freelancers
            modelBuilder.Entity<Freelancer>().HasData(
                new Freelancer { FreelancerID = 1, FreelancerFName = "Alice", FreelancerLName = "Johnson", FreelancerEmail = "alice.johnson@example.com", FreelancerBio = "Front-end developer specializing in React and UI design.", },
                new Freelancer { FreelancerID = 2, FreelancerFName = "Brian", FreelancerLName = "Smith", FreelancerEmail = "brian.smith@example.com", FreelancerBio = "Full-stack engineer with experience in ASP.NET Core and SQL Server." },
                new Freelancer { FreelancerID = 3, FreelancerFName = "Carla", FreelancerLName = "Nguyen", FreelancerEmail = "carla.nguyen@example.com", FreelancerBio = "Data analyst passionate about turning raw data into insights." },
                new Freelancer { FreelancerID = 4, FreelancerFName = "David", FreelancerLName = "Brown", FreelancerEmail = "david.brown@example.com", FreelancerBio = "Mobile app developer focusing on Android and Kotlin." },
                new Freelancer { FreelancerID = 5, FreelancerFName = "Ella", FreelancerLName = "Martinez", FreelancerEmail = "ella.martinez@example.com", FreelancerBio = "UX researcher with a background in psychology and design." },
                new Freelancer { FreelancerID = 6, FreelancerFName = "Felix", FreelancerLName = "Garcia", FreelancerEmail = "felix.garcia@example.com", FreelancerBio = "Cloud solutions architect experienced in Azure and AWS." },
                new Freelancer { FreelancerID = 7, FreelancerFName = "Grace", FreelancerLName = "Lee", FreelancerEmail = "grace.lee@example.com", FreelancerBio = "Content writer specializing in technical documentation." },
                new Freelancer { FreelancerID = 8, FreelancerFName = "Henry", FreelancerLName = "Wilson", FreelancerEmail = "henry.wilson@example.com", FreelancerBio = "Cybersecurity consultant with penetration testing expertise." },
                new Freelancer { FreelancerID = 9, FreelancerFName = "Isabella", FreelancerLName = "Taylor", FreelancerEmail = "isabella.taylor@example.com", FreelancerBio = "Graphic designer skilled in Adobe Creative Suite." },
                new Freelancer { FreelancerID = 10, FreelancerFName = "Jack", FreelancerLName = "Harris", FreelancerEmail = "jack.harris@example.com", FreelancerBio = "Backend developer with strong knowledge of C# and APIs." },
                new Freelancer { FreelancerID = 11, FreelancerFName = "Kylie", FreelancerLName = "Roberts", FreelancerEmail = "kylie.roberts@example.com", FreelancerBio = "SEO specialist helping businesses grow their online presence." },
                new Freelancer { FreelancerID = 12, FreelancerFName = "Liam", FreelancerLName = "Clark", FreelancerEmail = "liam.clark@example.com", FreelancerBio = "Game developer with Unity and C# experience." },
                new Freelancer { FreelancerID = 13, FreelancerFName = "Maya", FreelancerLName = "Lopez", FreelancerEmail = "maya.lopez@example.com", FreelancerBio = "Project manager with Agile and Scrum certifications." },
                new Freelancer { FreelancerID = 14, FreelancerFName = "Noah", FreelancerLName = "Hall", FreelancerEmail = "noah.hall@example.com", FreelancerBio = "AI researcher working on natural language processing." },
                new Freelancer { FreelancerID = 15, FreelancerFName = "Olivia", FreelancerLName = "Allen", FreelancerEmail = "olivia.allen@example.com", FreelancerBio = "Marketing strategist with expertise in digital campaigns." },
                new Freelancer { FreelancerID = 16, FreelancerFName = "Paul", FreelancerLName = "Young", FreelancerEmail = "paul.young@example.com", FreelancerBio = "DevOps engineer automating CI/CD pipelines." },
                new Freelancer { FreelancerID = 17, FreelancerFName = "Quinn", FreelancerLName = "Scott", FreelancerEmail = "quinn.scott@example.com", FreelancerBio = "Copywriter crafting compelling brand stories." },
                new Freelancer { FreelancerID = 18, FreelancerFName = "Rosa", FreelancerLName = "King", FreelancerEmail = "rosa.king@example.com", FreelancerBio = "Data scientist with Python and machine learning skills." },
                new Freelancer { FreelancerID = 19, FreelancerFName = "Sam", FreelancerLName = "Wright", FreelancerEmail = "sam.wright@example.com", FreelancerBio = "IT support specialist with strong troubleshooting skills." },
                new Freelancer { FreelancerID = 20, FreelancerFName = "Tina", FreelancerLName = "Evans", FreelancerEmail = "tina.evans@example.com", FreelancerBio = "Social media manager growing communities online." },
                new Freelancer { FreelancerID = 21, FreelancerFName = "Uma", FreelancerLName = "Hill", FreelancerEmail = "uma.hill@example.com", FreelancerBio = "QA tester ensuring software quality and reliability." },
                new Freelancer { FreelancerID = 22, FreelancerFName = "Victor", FreelancerLName = "Green", FreelancerEmail = "victor.green@example.com", FreelancerBio = "Blockchain developer building decentralized applications." },
                new Freelancer { FreelancerID = 23, FreelancerFName = "Wendy", FreelancerLName = "Adams", FreelancerEmail = "wendy.adams@example.com", FreelancerBio = "Illustrator creating digital art and storyboards." },
                new Freelancer { FreelancerID = 24, FreelancerFName = "Xavier", FreelancerLName = "Nelson", FreelancerEmail = "xavier.nelson@example.com", FreelancerBio = "Systems analyst optimizing enterprise workflows." },
                new Freelancer { FreelancerID = 25, FreelancerFName = "Yara", FreelancerLName = "Bennett", FreelancerEmail = "yara.bennett@example.com", FreelancerBio = "Web developer specializing in responsive design." });

            #endregion
            #region Projects
            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectID = 1, ProjectTitle = "E-Commerce Website", ProjectDescription = "Develop a responsive online store with payment integration.", ProjectBudget = 15000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 15) },
                new Project { ProjectID = 2, ProjectTitle = "Mobile Banking App", ProjectDescription = "Create a secure mobile app for banking transactions.", ProjectBudget = 30000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 10) },
                new Project { ProjectID = 3, ProjectTitle = "Data Analytics Dashboard", ProjectDescription = "Build a dashboard for visualizing business KPIs.", ProjectBudget = 12000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 3, 5) },
                new Project { ProjectID = 4, ProjectTitle = "Social Media Campaign", ProjectDescription = "Design and run a digital marketing campaign.", ProjectBudget = 8000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 20) },
                new Project { ProjectID = 5, ProjectTitle = "Inventory Management System", ProjectDescription = "Develop a system to track stock levels and sales.", ProjectBudget = 20000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 4, 1) },
                new Project { ProjectID = 6, ProjectTitle = "AI Chatbot", ProjectDescription = "Implement a customer support chatbot using NLP.", ProjectBudget = 18000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 2, 25) },
                new Project { ProjectID = 7, ProjectTitle = "Online Learning Platform", ProjectDescription = "Create a platform for hosting online courses.", ProjectBudget = 25000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 3, 15) },
                new Project { ProjectID = 8, ProjectTitle = "Restaurant Ordering App", ProjectDescription = "Develop a mobile app for food ordering and delivery.", ProjectBudget = 10000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 30) },
                new Project { ProjectID = 9, ProjectTitle = "Blockchain Wallet", ProjectDescription = "Build a secure cryptocurrency wallet application.", ProjectBudget = 35000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 18) },
                new Project { ProjectID = 10, ProjectTitle = "Fitness Tracker", ProjectDescription = "Develop a wearable app for tracking workouts.", ProjectBudget = 12000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 3, 25) },
                new Project { ProjectID = 11, ProjectTitle = "Smart Home Automation", ProjectDescription = "Create IoT solutions for home automation.", ProjectBudget = 40000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 4, 10) },
                new Project { ProjectID = 12, ProjectTitle = "Travel Booking System", ProjectDescription = "Develop a web app for booking flights and hotels.", ProjectBudget = 22000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 12) },
                new Project { ProjectID = 13, ProjectTitle = "Healthcare Portal", ProjectDescription = "Build a patient management and appointment system.", ProjectBudget = 28000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 28) },
                new Project { ProjectID = 14, ProjectTitle = "Music Streaming Service", ProjectDescription = "Develop a platform for streaming and sharing music.", ProjectBudget = 32000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 3, 8) },
                new Project { ProjectID = 15, ProjectTitle = "Job Recruitment Platform", ProjectDescription = "Create a system for posting and applying to jobs.", ProjectBudget = 15000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 4, 2) },
                new Project { ProjectID = 16, ProjectTitle = "Online Auction Site", ProjectDescription = "Develop a platform for online bidding and auctions.", ProjectBudget = 17000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 22) },
                new Project { ProjectID = 17, ProjectTitle = "Digital Wallet", ProjectDescription = "Create a mobile wallet for online payments.", ProjectBudget = 20000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 14) },
                new Project { ProjectID = 18, ProjectTitle = "Event Management System", ProjectDescription = "Develop a system for managing events and tickets.", ProjectBudget = 14000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 3, 12) },
                new Project { ProjectID = 19, ProjectTitle = "Online Grocery Store", ProjectDescription = "Build a web app for grocery shopping and delivery.", ProjectBudget = 16000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 4, 5) },
                new Project { ProjectID = 20, ProjectTitle = "Photo Editing App", ProjectDescription = "Develop a mobile app for editing and sharing photos.", ProjectBudget = 9000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 28) },
                new Project { ProjectID = 21, ProjectTitle = "Language Learning App", ProjectDescription = "Create an app for learning new languages interactively.", ProjectBudget = 13000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 20) },
                new Project { ProjectID = 22, ProjectTitle = "Crowdfunding Platform", ProjectDescription = "Develop a platform for funding creative projects.", ProjectBudget = 21000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 3, 18) },
                new Project { ProjectID = 23, ProjectTitle = "Online Survey Tool", ProjectDescription = "Build a tool for creating and analyzing surveys.", ProjectBudget = 7000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 4, 8) },
                new Project { ProjectID = 24, ProjectTitle = "Podcast Hosting Service", ProjectDescription = "Develop a platform for hosting and streaming podcasts.", ProjectBudget = 11000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 17) },
                new Project { ProjectID = 25, ProjectTitle = "Freelancer Marketplace", ProjectDescription = "Create a marketplace for hiring freelancers.", ProjectBudget = 26000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 22) }
            );
            #endregion

            //modelBuilder.Entity<Skill>

            // Configure many-to-many relationship between Freelancer and Skill
            //modelBuilder.Entity<FreelancerSkill>()
            //    .HasKey(fs => new { fs.FreelancerID, fs.SkillID });
            //modelBuilder.Entity<FreelancerSkill>()
            //    .HasOne(fs => fs.Freelancer)
            //    .WithMany(f => f.FreelancerSkills)
            //    .HasForeignKey(fs => fs.FreelancerID);
            //modelBuilder.Entity<FreelancerSkill>()
            //    .HasOne(fs => fs.Skill)
            //    .WithMany(s => s.FreelancerSkills)
            //    .HasForeignKey(fs => fs.SkillID);
        }
    }
}
