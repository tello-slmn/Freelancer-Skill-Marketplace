using Microsoft.AspNetCore.Identity;

namespace FSM.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientFName { get; set; }
        public string ClientLName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientCompanyName { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
