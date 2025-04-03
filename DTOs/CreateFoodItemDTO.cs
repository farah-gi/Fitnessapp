using System.ComponentModel.DataAnnotations;

namespace FitnessPlatform.API.DTOs
{
    /// <summary>
    /// Data transfer object for creating a new food item.
    /// </summary>
    public class CreateFoodItemDTO
    {
        /// <summary>
        /// Gets or sets the name of the food item.
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the quantity of the food item.
        /// </summary>
        [Required]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit of measurement for the quantity.
        /// </summary>
        [Required]
        public string Unit { get; set; } = string.Empty;
    }
} 