using System.ComponentModel.DataAnnotations;

namespace FSM.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        [Required(ErrorMessage = "Please enter project name.")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Please enter project description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter project budget.")]
        [Range(0, double.MaxValue, ErrorMessage = "Budget must be a positive number.")]
        public decimal Budget { get; set; }

        public bool Status { get; set; } = false; // Default to false (not completed)
    }
}
