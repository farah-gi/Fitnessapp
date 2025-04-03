using System.ComponentModel.DataAnnotations;

namespace FitnessPlatform.API.DTOs.UserDTOs
{
    public class UserRegisterDTO
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public decimal Height { get; set; }

        [Required]
        public decimal Weight { get; set; }

        [Required]
        public string FitnessGoal { get; set; }

        [Required]
        public string FitnessLevel { get; set; }
    }
} 