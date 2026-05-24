namespace FSM.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public decimal ProjectBudget { get; set; }
        public bool ProjectStatus { get; set; }
        public DateTime ProjectPostedDate { get; set; }
        //public int ClientID { get; set; }

        //public Client Client { get; set; }
        //public ICollection<Proposal> Proposals { get; set; }
        //public ICollection<Contract> Contracts { get; set; }
    }
}
