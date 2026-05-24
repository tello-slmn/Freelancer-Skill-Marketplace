using FSM.Models;

namespace FSM.Data
{
    public interface IFreelancerRepository
    {
        IEnumerable<Freelancer> AllFreelancers { get; }
        Freelancer GetFreelancerById(int freelancerId);
        void SaveChanges();
    }
}
