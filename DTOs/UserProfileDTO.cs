using System;
using fitnessApp.Models.Enums;

namespace fitnessApp.DTOs
{
    /// <summary>
    /// Data transfer object for user profile information.
    /// </summary>
    public class UserProfileDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the user's gender.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the display text for the user's gender.
        /// </summary>
        public string GenderDisplay { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's height in meters.
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the user's weight in kilograms.
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's profile picture.
        /// </summary>
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Gets or sets the user's dietary restrictions.
        /// </summary>
        public string? DietaryRestrictions { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user account was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the user's last login.
        /// </summary>
        public DateTime? LastLoginAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user account is active.
        /// </summary>
        public bool IsActive { get; set; }
    }
} 