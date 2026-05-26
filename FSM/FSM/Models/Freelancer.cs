namespace FSM.Models
{
    public class Freelancer
    {
        public int FreelancerID { get; set; }
        public string FreelancerFName { get; set; }
        public string FreelancerLName { get; set; }
        public string FreelancerEmail { get; set; }
        public string FreelancerBio { get; set; }

        public ICollection<FreelancerSkill> FreelancerSkills { get; set; }
    }
}
