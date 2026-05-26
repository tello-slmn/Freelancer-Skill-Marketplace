using FSM.Models;

namespace FSM.Data
{
    public interface IProjectRepository
    {
        IQueryable<Project> AllProjects { get; }
        Project GetProjectById(int projectId);
        void SaveChanges();
    }
}
