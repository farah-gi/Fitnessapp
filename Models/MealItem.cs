using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents a food item within a meal, including its nutritional information and quantity.
    /// </summary>
    public class MealItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MealItem"/> class.
        /// </summary>
        public MealItem()
        {
            Notes = string.Empty;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the meal item.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the meal this item belongs to.
        /// </summary>
        [Required]
        public int MealId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the food item being used.
        /// </summary>
        [Required]
        public int FoodItemId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the food item in the specified serving unit.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the total calories in this meal item.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal Calories { get; set; }

        /// <summary>
        /// Gets or sets the total protein content in grams for this meal item.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal Protein { get; set; }

        /// <summary>
        /// Gets or sets the total carbohydrates content in grams for this meal item.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal Carbs { get; set; }

        /// <summary>
        /// Gets or sets the total fat content in grams for this meal item.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal Fat { get; set; }

        /// <summary>
        /// Gets or sets any additional notes about this meal item.
        /// </summary>
        [MaxLength(1000)]
        public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date and time when this meal item was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this meal item was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the meal this item belongs to.
        /// </summary>
        public Meal Meal { get; set; } = null!;

        /// <summary>
        /// Gets or sets the food item being used.
        /// </summary>
        public FoodItem FoodItem { get; set; } = null!;
    }
} 