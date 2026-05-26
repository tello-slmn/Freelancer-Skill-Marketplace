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
        public DbSet<Skill> Skills { get; set; }
        public DbSet<FreelancerSkill> FreelancerSkills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Freelancer>().ToTable("Freelancer");
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Skill>().ToTable("Skill");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Proposal>().ToTable("Proposal");
            modelBuilder.Entity<Contract>().ToTable("Contract");
            modelBuilder.Entity<FreelancerSkill>().ToTable("FreelancerSkill");
        }
    }
}
