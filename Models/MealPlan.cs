using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models;

/// <summary>
/// Represents a meal plan that contains a collection of meals and nutritional targets.
/// </summary>
public class MealPlan
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MealPlan"/> class.
    /// </summary>
    public MealPlan()
    {
        UserId = string.Empty;
        Name = string.Empty;
        Description = string.Empty;
        Meals = new List<Meal>();
    }

    /// <summary>
    /// Gets or sets the unique identifier for the meal plan.
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who owns this meal plan.
    /// </summary>
    [Required]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the name of the meal plan.
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the detailed description of the meal plan.
    /// </summary>
    [MaxLength(1000)]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the start date of the meal plan.
    /// </summary>
    [Required]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the end date of the meal plan, if applicable.
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or sets the daily calorie target for this meal plan.
    /// </summary>
    [Required]
    [Precision(10, 2)]
    public decimal DailyCalorieTarget { get; set; }

    /// <summary>
    /// Gets or sets the daily protein target in grams for this meal plan.
    /// </summary>
    [Required]
    [Precision(10, 2)]
    public decimal DailyProteinTarget { get; set; }

    /// <summary>
    /// Gets or sets the daily carbohydrates target in grams for this meal plan.
    /// </summary>
    [Required]
    [Precision(10, 2)]
    public decimal DailyCarbsTarget { get; set; }

    /// <summary>
    /// Gets or sets the daily fat target in grams for this meal plan.
    /// </summary>
    [Required]
    [Precision(10, 2)]
    public decimal DailyFatTarget { get; set; }

    /// <summary>
    /// Gets or sets whether this meal plan is currently active.
    /// </summary>
    [Required]
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// Gets or sets the date and time when this meal plan was created.
    /// </summary>
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the date and time when this meal plan was last updated.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    // Navigation properties
    /// <summary>
    /// Gets or sets the user who owns this meal plan.
    /// </summary>
    public User User { get; set; } = null!;

    /// <summary>
    /// Gets or sets the collection of meals included in this meal plan.
    /// </summary>
    public ICollection<Meal> Meals { get; set; } = new List<Meal>();
} 