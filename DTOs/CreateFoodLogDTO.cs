using System.ComponentModel.DataAnnotations;

namespace FitnessPlatform.API.DTOs
{
    public class CreateFoodLogDTO
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string MealType { get; set; }

        [Required]
        public List<CreateFoodItemDTO> Items { get; set; }
    }
} 