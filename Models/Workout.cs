using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fitnessApp.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        [StringLength(50)]
        public string DifficultyLevel { get; set; }

        [Required]
        [StringLength(50)]
        public string TargetMuscleGroup { get; set; }

        [Required]
        public int UserId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<Exercise> Exercises { get; set; }
    }
} 