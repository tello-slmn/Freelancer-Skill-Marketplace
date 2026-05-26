namespace FSM.Models
{
    public class Contract
    {
        public int ContractID { get; set; }
        public int ProposalID { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public string ContractTerms { get; set; }
       
        public Proposal Proposal { get; set; }
    }
}
