using System.ComponentModel.DataAnnotations;

namespace FitnessPlatform.API.DTOs.UserDTOs
{
    public class UserUpdateDTO
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string FitnessGoal { get; set; }
        public string FitnessLevel { get; set; }
        public bool? CurrentInjury { get; set; }
        public string InjuryDescription { get; set; }
        public DateTime? InjuryDate { get; set; }
       // public string DietaryRestrictions { get; set; }
    }
} 