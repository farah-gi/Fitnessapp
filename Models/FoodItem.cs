using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents a food item with its nutritional information and serving details.
    /// </summary>
    public class FoodItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoodItem"/> class.
        /// </summary>
        public FoodItem()
        {
            Name = string.Empty;
            Description = string.Empty;
            ServingUnit = string.Empty;
            Notes = string.Empty;
            MealItems = new List<MealItem>();
        }

        /// <summary>
        /// Gets or sets the unique identifier for the food item.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the food item.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of the food item.
        /// </summary>
        [MaxLength(1000)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the number of calories per serving.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal CaloriesPerServing { get; set; }

        /// <summary>
        /// Gets or sets the amount of protein in grams per serving.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal ProteinPerServing { get; set; }

        /// <summary>
        /// Gets or sets the amount of carbohydrates in grams per serving.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal CarbsPerServing { get; set; }

        /// <summary>
        /// Gets or sets the amount of fat in grams per serving.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal FatPerServing { get; set; }

        /// <summary>
        /// Gets or sets the unit of measurement for the serving size (e.g., grams, ounces, cups).
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string ServingUnit { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the size of one serving in the specified unit.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal ServingSize { get; set; }

        /// <summary>
        /// Gets or sets any additional notes about the food item.
        /// </summary>
        [MaxLength(1000)]
        public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether this food item is currently active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when this food item was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this food item was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the collection of meal items that include this food item.
        /// </summary>
        public ICollection<MealItem> MealItems { get; set; } = new List<MealItem>();
    }
} 