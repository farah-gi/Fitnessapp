using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents an analysis of a user's exercise performance.
    /// </summary>
    public class ExerciseAnalysis
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseAnalysis"/> class.
        /// </summary>
        public ExerciseAnalysis()
        {
            UserId = string.Empty;
            Notes = string.Empty;
            Recommendations = string.Empty;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the exercise analysis.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the exercise being analyzed.
        /// </summary>
        [Required]
        public int ExerciseId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user whose exercise is being analyzed.
        /// </summary>
        [Required]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date when the analysis was performed.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the score for exercise form (0-10).
        /// </summary>
        [Required]
        [Precision(3, 1)]
        public decimal FormScore { get; set; }

        /// <summary>
        /// Gets or sets the score for exercise effort (0-10).
        /// </summary>
        [Required]
        [Precision(3, 1)]
        public decimal EffortScore { get; set; }

        /// <summary>
        /// Gets or sets any additional notes about the exercise analysis.
        /// </summary>
        [MaxLength(1000)]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets recommendations for improving the exercise performance.
        /// </summary>
        [MaxLength(1000)]
        public string? Recommendations { get; set; }

        /// <summary>
        /// Gets or sets the date and time when this analysis was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this analysis was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the exercise being analyzed.
        /// </summary>
        public Exercise Exercise { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user whose exercise is being analyzed.
        /// </summary>
        public User User { get; set; } = null!;
    }
} 