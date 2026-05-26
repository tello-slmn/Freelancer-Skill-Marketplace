using System.ComponentModel.DataAnnotations;

namespace FSM.Models
{
    public class Proposal
    {
        public int ProposalID { get; set; }
        public int ProjectID { get; set; }
        public int FreelancerID { get; set; }
        public decimal ProposalBidAmount { get; set; }
        public string ProposalMessage { get; set; }
        public bool ProposalStatus { get; set; } = false;

        public Project Project { get; set; }
        public Freelancer Freelancer { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
