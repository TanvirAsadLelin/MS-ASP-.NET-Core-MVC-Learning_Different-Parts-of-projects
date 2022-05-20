﻿using System.ComponentModel.DataAnnotations;

namespace Identity_Login_and_Registration_ASPCore_.ViewModels
{
    public class Login
    {

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
