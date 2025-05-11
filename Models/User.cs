using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaskManagement_api.Models;

namespace TaskManagement_api.Models
{
    public enum UserRole
    {
        Admin,
        User
    }

    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = null!;
        public UserRole Role { get; set; } = UserRole.User;

        public int? TaskId { get; set; }

        public virtual task? Task { get; set; } /*= null!;*/

    }
}
