using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fitnessApp.Models.Enums;

namespace fitnessApp.Models
{
    /// <summary>
    /// Represents an injury record for a user in the fitness application.
    /// </summary>
    public class UserInjury
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInjury"/> class.
        /// </summary>
        public UserInjury()
        {
            UserId = string.Empty;
            InjuryType = string.Empty;
            Description = string.Empty;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the user injury.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who has this injury.
        /// </summary>
        [Required]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of injury.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string InjuryType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of the injury.
        /// </summary>
        [MaxLength(1000)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the date when the injury occurred.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the injury was resolved, if applicable.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets whether this injury record is currently active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when this injury record was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when this injury record was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        /// <summary>
        /// Gets or sets the user who has this injury.
        /// </summary>
        public User User { get; set; } = null!;
    }
} 