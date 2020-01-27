using System;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    public class Member
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Name { get; set;}

        [StringLength(10)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set;}

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Email { get; set;}

       [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Classification { get; set;}

        
    }
}