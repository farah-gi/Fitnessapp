using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents a goal set by a user in the fitness application.
    /// </summary>
    public class UserGoal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGoal"/> class.
        /// </summary>
        public UserGoal()
        {
            Title = string.Empty;
            Description = string.Empty;
            GoalType = string.Empty;
            UserId = string.Empty;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the user goal.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who set this goal.
        /// </summary>
        [Required]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the title of the goal.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of the goal.
        /// </summary>
        [MaxLength(1000)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the type of goal (e.g., weight loss, muscle gain, endurance).
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string GoalType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the target value for the goal.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal TargetValue { get; set; }

        /// <summary>
        /// Gets or sets the start date of the goal.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the goal, if applicable.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets whether this goal is currently active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when this goal was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this goal was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the user who set this goal.
        /// </summary>
        public User User { get; set; } = null!;
    }
} 