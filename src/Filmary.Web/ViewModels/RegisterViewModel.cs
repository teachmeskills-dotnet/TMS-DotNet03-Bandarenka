﻿using System.ComponentModel.DataAnnotations;

namespace Filmary.Web.ViewModels

{
    /// <summary>
    /// Register view model.
    /// </summary>
    public class RegisterViewModel
    {
        /// <summary>
        /// Email.
        /// </summary>
        [Required(ErrorMessage = "Не указан Email")]
        [Display(Name = nameof(Email))]
        public string Email { get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [Required(ErrorMessage = "Не указано Имя пользователя")]
        [Display(Name = nameof(Username))]
        public string Username { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = nameof(Password))]
        public string Password { get; set; }

        /// <summary>
        /// Password confirm.
        /// </summary>
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords are different")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm your password")]
        public string PasswordConfirm { get; set; }
    }
}