using FSM.Models;

namespace FSM.Data
{
    public class FreelancerRepository : IFreelancerRepository
    {
        private readonly AppDbContext _appDbContext;

        public FreelancerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IQueryable<Freelancer> AllFreelancers => _appDbContext.Freelancers;

        public Freelancer GetFreelancerById(int freelancerId) => _appDbContext.Freelancers.FirstOrDefault(f => f.FreelancerID == freelancerId);

        public void SaveChanges() => _appDbContext.SaveChanges();
    }
}
