using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents a scheduled workout session for a user.
    /// </summary>
    public class WorkoutSchedule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutSchedule"/> class.
        /// </summary>
        public WorkoutSchedule()
        {
            UserId = string.Empty;
            Notes = string.Empty;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the workout schedule.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the workout plan being scheduled.
        /// </summary>
        [Required]
        public int WorkoutPlanId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who scheduled the workout.
        /// </summary>
        [Required]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date when the workout is scheduled.
        /// </summary>
        [Required]
        public DateTime ScheduledDate { get; set; }

        /// <summary>
        /// Gets or sets the time when the workout is scheduled.
        /// </summary>
        [Required]
        public TimeSpan ScheduledTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the workout has been completed.
        /// </summary>
        [Required]
        public bool IsCompleted { get; set; } = false;

        /// <summary>
        /// Gets or sets any additional notes about the scheduled workout.
        /// </summary>
        [StringLength(1000)]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the date and time when this schedule was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this schedule was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the workout plan being scheduled.
        /// </summary>
        public virtual WorkoutPlan WorkoutPlan { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user who scheduled the workout.
        /// </summary>
        public virtual User User { get; set; } = null!;
    }
} 