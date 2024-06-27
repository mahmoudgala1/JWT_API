﻿using System.ComponentModel.DataAnnotations;

namespace JWT_API.Dtoes
{
    public class LoginModelDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
