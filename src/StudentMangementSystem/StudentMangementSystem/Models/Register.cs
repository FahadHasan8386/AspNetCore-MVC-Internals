using System.ComponentModel.DataAnnotations;

namespace StudentMangementSystem.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select your gender.")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required.")]
        [GenderBasedAge]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6)]
        public string Password { get; set; } = string.Empty;
    }
}
