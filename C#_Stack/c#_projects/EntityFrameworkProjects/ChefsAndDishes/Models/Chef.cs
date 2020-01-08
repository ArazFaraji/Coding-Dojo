using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace ChefsAndDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        public DateTime Birthday {get; set;}
        public List<Dish> AllDishes {get; set;}
        
    }
}
