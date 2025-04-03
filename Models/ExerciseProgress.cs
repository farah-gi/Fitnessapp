using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents the progress of a user's exercise performance.
    /// </summary>
    public class ExerciseProgress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseProgress"/> class.
        /// </summary>
        public ExerciseProgress()
        {
            UserId = string.Empty;
            Notes = string.Empty;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the exercise progress.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the exercise.
        /// </summary>
        [Required]
        public int ExerciseId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user.
        /// </summary>
        [Required]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of sets performed.
        /// </summary>
        [Required]
        public int Sets { get; set; }

        /// <summary>
        /// Gets or sets the number of repetitions per set.
        /// </summary>
        [Required]
        public int Repetitions { get; set; }

        /// <summary>
        /// Gets or sets the weight used in the exercise, if applicable.
        /// </summary>
        [Precision(10, 2)]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or sets the duration of the exercise in minutes, if applicable.
        /// </summary>
        [Precision(10, 2)]
        public decimal? Duration { get; set; }

        /// <summary>
        /// Gets or sets any additional notes about the exercise progress.
        /// </summary>
        [MaxLength(1000)]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the date and time when this progress was recorded.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this progress was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the exercise associated with this progress.
        /// </summary>
        public Exercise Exercise { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user associated with this progress.
        /// </summary>
        public User User { get; set; } = null!;
    }
} 