using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class User
    {
        public int UserId {get; set;}
        [Required]
        [MinLength(2, ErrorMessage="First Name must be 2 characters or longer!")]
        public string FirstName {get; set;}
        [Required]
        [MinLength(2, ErrorMessage="Last Name must be 2 characters or longer!")]
        public string LastName {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [DataType(DataType.Password)]
        [Required]
        [MinLength(3, ErrorMessage="Password must be 3 characters or longer!")]
        public string Password {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Wedding> Planned {get; set;}
        public List<Guest> Attending {get; set;}
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get; set;}

    }
}