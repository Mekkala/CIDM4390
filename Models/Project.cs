using System;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set;}

        [Required, StringLength(300)]
        public string Details { get; set;}
        
    }
}