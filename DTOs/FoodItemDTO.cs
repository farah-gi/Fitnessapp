using System;
using System.ComponentModel.DataAnnotations;
using fitnessApp.Models;

namespace fitnessApp.Models
{
    /// <summary>
    /// Data transfer object for food item information.
    /// </summary>
    public class FoodItemDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier for the food item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the food item.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the quantity of the food item.
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit of measurement for the quantity.
        /// </summary>
        public string Unit { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of calories in the food item.
        /// </summary>
        public decimal Calories { get; set; }

        /// <summary>
        /// Gets or sets the amount of protein in grams.
        /// </summary>
        public decimal Protein { get; set; }

        /// <summary>
        /// Gets or sets the amount of carbohydrates in grams.
        /// </summary>
        public decimal Carbs { get; set; }

        /// <summary>
        /// Gets or sets the amount of fat in grams.
        /// </summary>
        public decimal Fat { get; set; }
    }
} 