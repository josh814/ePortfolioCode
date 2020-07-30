using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(4, ErrorMessage = "The entered name is too short")]
        public string Name { get;  set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Your message is too long. Please reduce the size.")]
        public string Message { get; set; }
    }
}
