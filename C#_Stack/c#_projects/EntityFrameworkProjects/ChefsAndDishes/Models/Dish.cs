using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ChefsAndDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        [Range(0,10000, ErrorMessage = "Value must be between 0 and 10,000")]
        public int Calories {get; set;}
        [Required]
        public string Description {get; set;}
        [Required]
        public int Tastiness {get; set;}
        public int ChefId {get; set;}
        public Chef Creator {get; set;}

    }
}