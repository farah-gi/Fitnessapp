using System;
using System.ComponentModel.DataAnnotations;
using fitnessApp.Models.Enums;

namespace fitnessApp.DTOs
{
    /// <summary>
    /// Data transfer object for user registration.
    /// </summary>
    public class UserRegistrationDTO
    {
        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the confirmation of the user's password.
        /// </summary>
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's date of birth.
        /// </summary>
        [Required]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the user's gender.
        /// </summary>
        [Required]
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the user's height in meters.
        /// </summary>
        [Required]
        [Range(0, 300)]
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the user's weight in kilograms.
        /// </summary>
        [Required]
        [Range(0, 500)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets the user's dietary restrictions.
        /// </summary>
        [StringLength(500)]
        public string? DietaryRestrictions { get; set; }
    }
} 