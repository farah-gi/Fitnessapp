using System;
using System.ComponentModel.DataAnnotations;
using fitnessApp.Models;

namespace fitnessApp.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string FitnessGoal { get; set; }
        public string FitnessLevel { get; set; }
        public bool CurrentInjury { get; set; }
        public string InjuryDescription { get; set; }
        public DateTime? InjuryDate { get; set; }
        public string DietaryRestrictions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public bool IsActive { get; set; }
    }
} 