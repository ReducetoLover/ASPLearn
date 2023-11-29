using System.ComponentModel.DataAnnotations;

namespace ASPLearn.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Please enter you email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter a valid email address")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Please enter you phone numder")]
        public required string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
