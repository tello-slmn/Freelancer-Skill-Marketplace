using FSM.Models;

namespace FSM.Data
{
    public class ProjectRepository : IProjectRepository
    {
        public IEnumerable<Project> AllProjects =>
        [
            new Project { ProjectID = 1, ProjectTitle = "E-Commerce Website", ProjectDescription = "Develop a responsive online store with payment integration.", ProjectBudget = 15000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 15) },
            new Project { ProjectID = 2, ProjectTitle = "Mobile Banking App", ProjectDescription = "Create a secure mobile app for banking transactions.", ProjectBudget = 30000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 10) },
            new Project { ProjectID = 3, ProjectTitle = "Data Analytics Dashboard", ProjectDescription = "Build a dashboard for visualizing business KPIs.", ProjectBudget = 12000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 3, 5) },
            new Project { ProjectID = 4, ProjectTitle = "Social Media Campaign", ProjectDescription = "Design and run a digital marketing campaign.", ProjectBudget = 8000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 20) },
            new Project { ProjectID = 5, ProjectTitle = "Inventory Management System", ProjectDescription = "Develop a system to track stock levels and sales.", ProjectBudget = 20000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 4, 1) },
            new Project { ProjectID = 6, ProjectTitle = "AI Chatbot", ProjectDescription = "Implement a customer support chatbot using NLP.", ProjectBudget = 18000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 2, 25) },
            new Project { ProjectID = 7, ProjectTitle = "Online Learning Platform",ProjectDescription = "Create a platform for hosting online courses.",ProjectBudget = 25000m,ProjectStatus = false,ProjectPostedDate = new DateTime(2026, 3, 15) },
            new Project { ProjectID = 8, ProjectTitle = "Restaurant Ordering App", ProjectDescription = "Develop a mobile app for food ordering and delivery.", ProjectBudget = 10000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 30) },
            new Project { ProjectID = 9, ProjectTitle = "Blockchain Wallet", ProjectDescription = "Build a secure cryptocurrency wallet application.", ProjectBudget = 35000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 18) },
            new Project { ProjectID = 10, ProjectTitle = "Fitness Tracker", ProjectDescription = "Develop a wearable app for tracking workouts.", ProjectBudget = 12000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 3, 25) },
            new Project { ProjectID = 11, ProjectTitle = "Smart Home Automation", ProjectDescription = "Create IoT solutions for home automation.", ProjectBudget = 40000m, ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 4, 10) },
            new Project { ProjectID = 12, ProjectTitle = "Travel Booking System", ProjectDescription = "Develop a web app for booking flights and hotels.", ProjectBudget = 22000m, ProjectStatus = true, ProjectPostedDate = new DateTime(2026, 1, 12) },
            new Project { ProjectID = 13, ProjectTitle = "Healthcare Portal", ProjectDescription = "Build a patient management and appointment system.",ProjectBudget = 28000m,ProjectStatus = false, ProjectPostedDate = new DateTime(2026, 2, 28) },
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
        ];

        public Project GetProjectById(int projectId) => AllProjects.FirstOrDefault(p => p.ProjectID == projectId);
    }
}
