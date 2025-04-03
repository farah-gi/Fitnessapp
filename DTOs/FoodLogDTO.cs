using System;
using System.ComponentModel.DataAnnotations;

namespace fitnessApp.API.DTOs
{
    public class FoodLogDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FoodItemId { get; set; }
        public DateTime Date { get; set; }
        public string MealType { get; set; }
        public decimal Quantity { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
} 