using FSM.Models;

namespace FSM.Data
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProjectRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Project> AllProjects => _appDbContext.Projects;

        public Project GetProjectById(int projectId) => _appDbContext.Projects.FirstOrDefault(p => p.ProjectID == projectId);

        public void SaveChanges() => _appDbContext.SaveChanges();
    }
}
