using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents an exercise within a workout plan, including its specific configuration and details.
    /// </summary>
    public class WorkoutPlanExercise
    {
        /// <summary>
        /// Gets or sets the unique identifier for the workout plan exercise.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the workout plan this exercise belongs to.
        /// </summary>
        [Required]
        public int WorkoutPlanId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the exercise being performed.
        /// </summary>
        [Required]
        public int ExerciseId { get; set; }

        /// <summary>
        /// Gets or sets the number of sets to be performed for this exercise.
        /// </summary>
        [Required]
        public int Sets { get; set; }

        /// <summary>
        /// Gets or sets the number of repetitions to be performed in each set.
        /// </summary>
        [Required]
        public int Repetitions { get; set; }

        /// <summary>
        /// Gets or sets the rest time in seconds between sets.
        /// </summary>
        [Required]
        public int RestTimeInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the weight in kilograms to be used for this exercise.
        /// </summary>
        [Precision(10, 2)]
        public decimal? WeightInKg { get; set; }

        /// <summary>
        /// Gets or sets the duration in minutes for this exercise.
        /// </summary>
        [Precision(10, 2)]
        public decimal? DurationInMinutes { get; set; }

        /// <summary>
        /// Gets or sets any additional notes or instructions for this exercise.
        /// </summary>
        [MaxLength(1000)]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the difficulty level of this exercise within the workout plan.
        /// </summary>
        [Required]
        public DifficultyLevel DifficultyLevel { get; set; }

        /// <summary>
        /// Gets or sets the date and time when this workout plan exercise was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this workout plan exercise was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the workout plan this exercise belongs to.
        /// </summary>
        public WorkoutPlan WorkoutPlan { get; set; } = null!;

        /// <summary>
        /// Gets or sets the exercise being performed.
        /// </summary>
        public Exercise Exercise { get; set; } = null!;
    }
} 