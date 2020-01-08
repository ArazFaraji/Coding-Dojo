using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Guest
    {
        [Key]
        public int GuestId {get; set;}
        public int UserId {get; set;}
        public User Attendee {get; set;}
        public int WeddingId {get; set;}
        public Wedding Wedding {get; set;}

    }
}