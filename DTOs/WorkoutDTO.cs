using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace fitnessApp.Models
{
    public class WorkoutDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }
        public string TargetMuscleGroup { get; set; }
        public int Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public List<ExerciseDTO> Exercises { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }
    
} 