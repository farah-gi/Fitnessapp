using System;
using System.ComponentModel.DataAnnotations;
using fitnessApp.Models;

namespace fitnessApp.Models
{
    /// <summary>
    /// Data transfer object for exercise information.
    /// </summary>
    public class ExerciseDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier for the exercise.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the exercise.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the exercise.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the primary muscle group targeted by the exercise.
        /// </summary>
        public string MuscleGroup { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of sets recommended for the exercise.
        /// </summary>
        public int Sets { get; set; }

        /// <summary>
        /// Gets or sets the number of repetitions recommended per set.
        /// </summary>
        public int Reps { get; set; }

        /// <summary>
        /// Gets or sets the duration of the exercise in seconds.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the equipment required for the exercise.
        /// </summary>
        public string Equipment { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL to a video demonstration of the exercise.
        /// </summary>
        public string VideoUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL to an image of the exercise.
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of step-by-step instructions for performing the exercise.
        /// </summary>
        public List<string> Instructions { get; set; } = new();

        /// <summary>
        /// Gets or sets the list of tips for performing the exercise correctly.
        /// </summary>
        public List<string> Tips { get; set; } = new();
    }
}
