namespace FSM.Models
{
    public class Contract
    {
        public int ContractID { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public string ContractTerms { get; set; }
        public int ProjectID { get; set; }
        public int FreelancerID { get; set; }

        public Project Project { get; set; }
        public Freelancer Freelancer { get; set; }
    }
}
