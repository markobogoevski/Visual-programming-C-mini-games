﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5,ErrorMessage ="Name should be at least 5 characters!")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250,ErrorMessage ="Message is too long!")]
        public string Message { get; set; }
    }
}
