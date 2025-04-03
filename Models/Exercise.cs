using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents an exercise that can be included in workout plans.
    /// </summary>
    public class Exercise
    {
        /// <summary>
        /// Gets or sets the unique identifier for the exercise.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the exercise.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of how to perform the exercise.
        /// </summary>
        [MaxLength(1000)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the primary muscle group targeted by this exercise.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string MuscleGroup { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the equipment required to perform this exercise.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Equipment { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the difficulty level of this exercise.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string DifficultyLevel { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the step-by-step instructions for performing the exercise.
        /// </summary>
        [MaxLength(1000)]
        public string? Instructions { get; set; }

        /// <summary>
        /// Gets or sets the URL of an image demonstrating the exercise.
        /// </summary>
        [StringLength(255)]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the URL of a video demonstrating the exercise.
        /// </summary>
        [MaxLength(255)]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Gets or sets whether this exercise is currently active and available for use.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when this exercise was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this exercise was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the collection of workout plans that include this exercise.
        /// </summary>
        public ICollection<WorkoutPlanExercise> WorkoutPlanExercises { get; set; } = new List<WorkoutPlanExercise>();

        /// <summary>
        /// Gets or sets the collection of progress records for this exercise.
        /// </summary>
        public ICollection<ExerciseProgress> ExerciseProgresses { get; set; } = new List<ExerciseProgress>();

        /// <summary>
        /// Gets or sets the collection of analysis records for this exercise.
        /// </summary>
        public ICollection<ExerciseAnalysis> ExerciseAnalyses { get; set; } = new List<ExerciseAnalysis>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Exercise"/> class.
        /// </summary>
        public Exercise()
        {
            Name = string.Empty;
            MuscleGroup = string.Empty;
            Equipment = string.Empty;
            DifficultyLevel = string.Empty;
        }
    }
} 