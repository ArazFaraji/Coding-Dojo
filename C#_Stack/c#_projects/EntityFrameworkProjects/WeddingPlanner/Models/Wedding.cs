using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get; set;}
        [Required]
        public string WedderOne {get; set;}
        [Required]
        public string WedderTwo {get; set;}
        [Required]
        public DateTime Date {get; set;}
        [Required]
        public string WeddingAddress {get; set;}
        public int UserId {get; set;}
        public User Creator {get; set;}
        public List<Guest> Attendees {get; set;}

    }
}