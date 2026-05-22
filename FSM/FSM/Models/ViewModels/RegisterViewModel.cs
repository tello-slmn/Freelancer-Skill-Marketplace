using System.ComponentModel.DataAnnotations;

namespace FSM.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        [Required]
        [UIHint("password")]
        public string ConfirmPassword { get; set; }
    }
}
