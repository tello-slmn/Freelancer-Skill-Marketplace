using FSM.Models;

namespace FSM.Data
{
    public interface IProjectRepository
    {
        IEnumerable<Project> AllProjects { get; }
        Project GetProjectById(int projectId);
    }
}
