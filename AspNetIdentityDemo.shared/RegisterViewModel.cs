using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetIdentityDemo.shared
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength:50,MinimumLength =5)]
        public string Password { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        //[Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
