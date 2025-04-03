using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents a user in the fitness application, extending IdentityUser with additional fitness-related properties.
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            MedicalConditions = string.Empty;
            Allergies = string.Empty;
            Medications = string.Empty;
            ProfilePictureUrl = string.Empty;
            DietaryRestrictions = string.Empty;
            WorkoutPlans = new List<WorkoutPlan>();
            WorkoutSchedules = new List<WorkoutSchedule>();
            ExerciseProgresses = new List<ExerciseProgress>();
            ExerciseAnalyses = new List<ExerciseAnalysis>();
            MealPlans = new List<MealPlan>();
            UserGoals = new List<UserGoal>();
            UserInjuries = new List<UserInjury>();
        }

        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's gender.
        /// </summary>
        [Required]
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the user's date of birth.
        /// </summary>
        [Required]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the user's height in meters.
        /// </summary>
        [Required]
        [Precision(5, 2)]
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the user's weight in kilograms.
        /// </summary>
        [Required]
        [Precision(5, 2)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets the user's body fat percentage.
        /// </summary>
        [Precision(5, 2)]
        public decimal? BodyFatPercentage { get; set; }

        /// <summary>
        /// Gets or sets the user's muscle mass in kilograms.
        /// </summary>
        [Precision(5, 2)]
        public decimal? MuscleMass { get; set; }

        /// <summary>
        /// Gets or sets any medical conditions the user has.
        /// </summary>
        [MaxLength(1000)]
        public string MedicalConditions { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any allergies the user has.
        /// </summary>
        [MaxLength(1000)]
        public string Allergies { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any medications the user is taking.
        /// </summary>
        [MaxLength(1000)]
        public string Medications { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether the user account is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when the user account was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when the user account was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's profile picture.
        /// </summary>
        [MaxLength(255)]
        public string ProfilePictureUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any dietary restrictions the user has.
        /// </summary>
        [MaxLength(500)]
        public string DietaryRestrictions { get; set; } = string.Empty;

        // Navigation properties
        /// <summary>
        /// Gets or sets the collection of workout plans created by the user.
        /// </summary>
        public virtual ICollection<WorkoutPlan> WorkoutPlans { get; set; }

        /// <summary>
        /// Gets or sets the collection of workout schedules created by the user.
        /// </summary>
        public virtual ICollection<WorkoutSchedule> WorkoutSchedules { get; set; }

        /// <summary>
        /// Gets or sets the collection of meal plans created by the user.
        /// </summary>
        public virtual ICollection<MealPlan> MealPlans { get; set; }

        /// <summary>
        /// Gets or sets the collection of exercise progress records for the user.
        /// </summary>
        public virtual ICollection<ExerciseProgress> ExerciseProgresses { get; set; }

        /// <summary>
        /// Gets or sets the collection of exercise analysis records for the user.
        /// </summary>
        public virtual ICollection<ExerciseAnalysis> ExerciseAnalyses { get; set; }

        /// <summary>
        /// Gets or sets the collection of goals set by the user.
        /// </summary>
        public virtual ICollection<UserGoal> UserGoals { get; set; }

        /// <summary>
        /// Gets or sets the collection of injury records for the user.
        /// </summary>
        public virtual ICollection<UserInjury> UserInjuries { get; set; }
    }
} 