using System;
using System.ComponentModel.DataAnnotations;
using fitnessApp.Models;

namespace fitnessApp.Models
{
    /// <summary>
    /// Data transfer object for user login.
    /// </summary>
    public class UserLoginDTO
    {
        /// <summary>
        /// Gets or sets the username for login.
        /// </summary>
        [Required]
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password for login.
        /// </summary>
        [Required]
        public string Password { get; set; } = string.Empty;
    }
} 