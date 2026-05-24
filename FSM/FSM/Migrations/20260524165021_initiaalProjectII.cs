using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSM.Migrations
{
    /// <inheritdoc />
    public partial class initiaalProjectII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Freelancers",
                columns: table => new
                {
                    FreelancerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerFName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreelancerLName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreelancerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreelancerBio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancers", x => x.FreelancerID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProjectStatus = table.Column<bool>(type: "bit", nullable: false),
                    ProjectPostedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });

            migrationBuilder.InsertData(
                table: "Freelancers",
                columns: new[] { "FreelancerID", "FreelancerBio", "FreelancerEmail", "FreelancerFName", "FreelancerLName" },
                values: new object[,]
                {
                    { 1, "Front-end developer specializing in React and UI design.", "alice.johnson@example.com", "Alice", "Johnson" },
                    { 2, "Full-stack engineer with experience in ASP.NET Core and SQL Server.", "brian.smith@example.com", "Brian", "Smith" },
                    { 3, "Data analyst passionate about turning raw data into insights.", "carla.nguyen@example.com", "Carla", "Nguyen" },
                    { 4, "Mobile app developer focusing on Android and Kotlin.", "david.brown@example.com", "David", "Brown" },
                    { 5, "UX researcher with a background in psychology and design.", "ella.martinez@example.com", "Ella", "Martinez" },
                    { 6, "Cloud solutions architect experienced in Azure and AWS.", "felix.garcia@example.com", "Felix", "Garcia" },
                    { 7, "Content writer specializing in technical documentation.", "grace.lee@example.com", "Grace", "Lee" },
                    { 8, "Cybersecurity consultant with penetration testing expertise.", "henry.wilson@example.com", "Henry", "Wilson" },
                    { 9, "Graphic designer skilled in Adobe Creative Suite.", "isabella.taylor@example.com", "Isabella", "Taylor" },
                    { 10, "Backend developer with strong knowledge of C# and APIs.", "jack.harris@example.com", "Jack", "Harris" },
                    { 11, "SEO specialist helping businesses grow their online presence.", "kylie.roberts@example.com", "Kylie", "Roberts" },
                    { 12, "Game developer with Unity and C# experience.", "liam.clark@example.com", "Liam", "Clark" },
                    { 13, "Project manager with Agile and Scrum certifications.", "maya.lopez@example.com", "Maya", "Lopez" },
                    { 14, "AI researcher working on natural language processing.", "noah.hall@example.com", "Noah", "Hall" },
                    { 15, "Marketing strategist with expertise in digital campaigns.", "olivia.allen@example.com", "Olivia", "Allen" },
                    { 16, "DevOps engineer automating CI/CD pipelines.", "paul.young@example.com", "Paul", "Young" },
                    { 17, "Copywriter crafting compelling brand stories.", "quinn.scott@example.com", "Quinn", "Scott" },
                    { 18, "Data scientist with Python and machine learning skills.", "rosa.king@example.com", "Rosa", "King" },
                    { 19, "IT support specialist with strong troubleshooting skills.", "sam.wright@example.com", "Sam", "Wright" },
                    { 20, "Social media manager growing communities online.", "tina.evans@example.com", "Tina", "Evans" },
                    { 21, "QA tester ensuring software quality and reliability.", "uma.hill@example.com", "Uma", "Hill" },
                    { 22, "Blockchain developer building decentralized applications.", "victor.green@example.com", "Victor", "Green" },
                    { 23, "Illustrator creating digital art and storyboards.", "wendy.adams@example.com", "Wendy", "Adams" },
                    { 24, "Systems analyst optimizing enterprise workflows.", "xavier.nelson@example.com", "Xavier", "Nelson" },
                    { 25, "Web developer specializing in responsive design.", "yara.bennett@example.com", "Yara", "Bennett" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "ProjectBudget", "ProjectDescription", "ProjectPostedDate", "ProjectStatus", "ProjectTitle" },
                values: new object[,]
                {
                    { 1, 15000m, "Develop a responsive online store with payment integration.", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "E-Commerce Website" },
                    { 2, 30000m, "Create a secure mobile app for banking transactions.", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mobile Banking App" },
                    { 3, 12000m, "Build a dashboard for visualizing business KPIs.", new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Data Analytics Dashboard" },
                    { 4, 8000m, "Design and run a digital marketing campaign.", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Social Media Campaign" },
                    { 5, 20000m, "Develop a system to track stock levels and sales.", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Inventory Management System" },
                    { 6, 18000m, "Implement a customer support chatbot using NLP.", new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "AI Chatbot" },
                    { 7, 25000m, "Create a platform for hosting online courses.", new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Online Learning Platform" },
                    { 8, 10000m, "Develop a mobile app for food ordering and delivery.", new DateTime(2026, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Restaurant Ordering App" },
                    { 9, 35000m, "Build a secure cryptocurrency wallet application.", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Blockchain Wallet" },
                    { 10, 12000m, "Develop a wearable app for tracking workouts.", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Fitness Tracker" },
                    { 11, 40000m, "Create IoT solutions for home automation.", new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Smart Home Automation" },
                    { 12, 22000m, "Develop a web app for booking flights and hotels.", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Travel Booking System" },
                    { 13, 28000m, "Build a patient management and appointment system.", new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Healthcare Portal" },
                    { 14, 32000m, "Develop a platform for streaming and sharing music.", new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Music Streaming Service" },
                    { 15, 15000m, "Create a system for posting and applying to jobs.", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Job Recruitment Platform" },
                    { 16, 17000m, "Develop a platform for online bidding and auctions.", new DateTime(2026, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Online Auction Site" },
                    { 17, 20000m, "Create a mobile wallet for online payments.", new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Digital Wallet" },
                    { 18, 14000m, "Develop a system for managing events and tickets.", new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Event Management System" },
                    { 19, 16000m, "Build a web app for grocery shopping and delivery.", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Online Grocery Store" },
                    { 20, 9000m, "Develop a mobile app for editing and sharing photos.", new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Photo Editing App" },
                    { 21, 13000m, "Create an app for learning new languages interactively.", new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Language Learning App" },
                    { 22, 21000m, "Develop a platform for funding creative projects.", new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Crowdfunding Platform" },
                    { 23, 7000m, "Build a tool for creating and analyzing surveys.", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Online Survey Tool" },
                    { 24, 11000m, "Develop a platform for hosting and streaming podcasts.", new DateTime(2026, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Podcast Hosting Service" },
                    { 25, 26000m, "Create a marketplace for hiring freelancers.", new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Freelancer Marketplace" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Freelancers");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
