using System.ComponentModel.DataAnnotations;
using fitnessApp.Models.Enums;

namespace fitnessApp.DTOs
{
    /// <summary>
    /// Data transfer object for creating a new exercise.
    /// </summary>
    public class CreateExerciseDTO
    {
        /// <summary>
        /// Gets or sets the name of the exercise.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of how to perform the exercise.
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of exercise (e.g., strength, cardio, flexibility).
        /// </summary>
        [Required]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the primary muscle group targeted by this exercise.
        /// </summary>
        [Required]
        public string PrimaryMuscleGroup { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of secondary muscle groups targeted by this exercise.
        /// </summary>
        public List<string> SecondaryMuscleGroups { get; set; } = new();

        /// <summary>
        /// Gets or sets the difficulty level of the exercise.
        /// </summary>
        [Required]
        public DifficultyLevel DifficultyLevel { get; set; }

        /// <summary>
        /// Gets or sets additional tips for performing the exercise correctly.
        /// </summary>
        [MaxLength(1000)]
        public string? Tips { get; set; }

        /// <summary>
        /// Gets or sets the equipment needed to perform this exercise.
        /// </summary>
        [MaxLength(1000)]
        public string? EquipmentNeeded { get; set; }

        /// <summary>
        /// Gets or sets the URL of a video demonstrating the exercise.
        /// </summary>
        [MaxLength(1000)]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Gets or sets the URL of an image demonstrating the exercise.
        /// </summary>
        [MaxLength(1000)]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this exercise is active.
        /// </summary>
        public bool IsActive { get; set; } = true;
    }
}