using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents a workout plan that contains a collection of exercises.
    /// </summary>
    public class WorkoutPlan
    {
        /// <summary>
        /// Gets or sets the unique identifier for the workout plan.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who owns this workout plan.
        /// </summary>
        [Required]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the workout plan.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of the workout plan.
        /// </summary>
        [MaxLength(1000)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the start date of the workout plan.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the workout plan, if applicable.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the difficulty level of the workout plan.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string DifficultyLevel { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of times per week the workout plan should be performed.
        /// </summary>
        [Required]
        public int FrequencyPerWeek { get; set; }

        /// <summary>
        /// Gets or sets whether this workout plan is currently active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when this workout plan was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this workout plan was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the user who owns this workout plan.
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the collection of exercises included in this workout plan.
        /// </summary>
        public ICollection<WorkoutPlanExercise> WorkoutPlanExercises { get; set; } = new List<WorkoutPlanExercise>();

        /// <summary>
        /// Gets or sets the collection of schedules for this workout plan.
        /// </summary>
        public ICollection<WorkoutSchedule> WorkoutSchedules { get; set; } = new List<WorkoutSchedule>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutPlan"/> class.
        /// </summary>
        public WorkoutPlan()
        {
            Name = string.Empty;
            DifficultyLevel = string.Empty;
            UserId = string.Empty;
        }
    }
} 