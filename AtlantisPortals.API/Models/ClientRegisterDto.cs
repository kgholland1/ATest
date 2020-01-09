﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AtlantisPortals.API.Models
{
    public class ClientRegisterDto
    {
        [Required(ErrorMessage = "Please enter an email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 20 characters")]
        public string Password { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }

        [MaxLength(200)]
        public string FullName { get; set; }
        // [IntegerValidator(MinValue = 1)]
        [Range(1, Int64.MaxValue, ErrorMessage = "Please select your agency")]
        public int AgencyId { get; set; }
    }
}
