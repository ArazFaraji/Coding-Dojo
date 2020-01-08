using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private static MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        } 


        public IActionResult Index()
        {
            ViewBag.AllDishes = dbContext.Dishes.ToList();
            return View();
        }



        [HttpGet("New")]
        public IActionResult New()
        {
            return View();
        }



        [HttpPost("NewDish")]
        public IActionResult NewDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet("{DishId}")]
        public IActionResult DishInfo(int DishId)
        {
            ViewBag.InfoDish = dbContext.Dishes
                .FirstOrDefault(i => i.DishId == DishId);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("Delete/{DishID}")]
        public IActionResult DeleteDish(int DishID)
        {
            Dish RetrievedDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == DishID);
            dbContext.Dishes.Remove(RetrievedDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("Edit/{DishID}")]
        public IActionResult EditDish(int DishID)
        {
            Dish RetrievedDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == DishID);
            ViewBag.Dish = RetrievedDish;
            return View();
        }

        [HttpPost("Process/{DishID}")]
        public IActionResult ProcessEditDish(int DishID, Dish CurrentDish)
        {
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == DishID);
            RetrievedDish.Name = CurrentDish.Name;
            RetrievedDish.Chef = CurrentDish.Chef;
            RetrievedDish.Tastiness = CurrentDish.Tastiness;
            RetrievedDish.Calories = CurrentDish.Calories;
            RetrievedDish.Description = CurrentDish.Description;
            dbContext.SaveChanges();


            return Redirect($"/{DishID}");
        }
    }
}
