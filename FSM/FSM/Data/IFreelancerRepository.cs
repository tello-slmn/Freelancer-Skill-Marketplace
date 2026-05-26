using FSM.Models;

namespace FSM.Data
{
    public interface IFreelancerRepository
    {
        IQueryable<Freelancer> AllFreelancers { get; }
        Freelancer GetFreelancerById(int freelancerId);
        void SaveChanges();
    }
}
