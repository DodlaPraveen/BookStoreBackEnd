﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Models
{
    public class RegistrationModel
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Mobile_Number { get; set; }
    }
}
