using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents a meal within a meal plan, containing nutritional information and meal items.
    /// </summary>
    public class Meal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meal"/> class.
        /// </summary>
        public Meal()
        {
            Name = string.Empty;
            Description = string.Empty;
            MealTime = string.Empty;
            MealItems = new List<MealItem>();
        }

        /// <summary>
        /// Gets or sets the unique identifier for the meal.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the meal plan this meal belongs to.
        /// </summary>
        [Required]
        public int MealPlanId { get; set; }

        /// <summary>
        /// Gets or sets the name of the meal.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of the meal.
        /// </summary>
        [MaxLength(1000)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the time of day when this meal should be consumed.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string MealTime { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total calories in this meal.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal TotalCalories { get; set; }

        /// <summary>
        /// Gets or sets the total protein content in grams for this meal.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal TotalProtein { get; set; }

        /// <summary>
        /// Gets or sets the total carbohydrates content in grams for this meal.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal TotalCarbs { get; set; }

        /// <summary>
        /// Gets or sets the total fat content in grams for this meal.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal TotalFat { get; set; }

        /// <summary>
        /// Gets or sets whether this meal is currently active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when this meal was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this meal was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the meal plan this meal belongs to.
        /// </summary>
        public MealPlan MealPlan { get; set; } = null!;

        /// <summary>
        /// Gets or sets the collection of food items included in this meal.
        /// </summary>
        public ICollection<MealItem> MealItems { get; set; } = new List<MealItem>();
    }
} 