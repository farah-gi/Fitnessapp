using System;
using System.ComponentModel.DataAnnotations;
using fitnessApp.Models;
using fitnessApp.DTOs;

namespace fitnessApp.DTOs
{
    public class CreateWorkoutDTO
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Difficulty { get; set; }

        [Required]
        public string TargetMuscleGroup { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public List<CreateExerciseDTO> Exercises { get; set; }
    }
}