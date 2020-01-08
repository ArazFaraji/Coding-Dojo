using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ChefsAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            ViewBag.AllChefs = dbContext.Chefs
            .Include(i => i.AllDishes);
            return View();
        }

        [HttpGet("NewChef")]
        public IActionResult NewChef()
        {
            return View();
        }

        [HttpPost("AddNewChef")]
        public IActionResult AddNewChef(Chef newChef)
        {
            var ageCheck = DateTime.Now.Year - newChef.Birthday.Year;
            if(ageCheck < 18)
            {
                ModelState.AddModelError("Birthday", "Must be at least 18 years old");
                return View("NewChef");
            }
            dbContext.Add(newChef);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Dishes()
        {
            ViewBag.AllChefs = dbContext.Chefs;

            ViewBag.AllDishes = dbContext.Dishes
            .Include(i => i.Creator);
            return View();
        }

        [HttpGet("NewDish")]
        public IActionResult NewDish()
        {
            ViewBag.AllDishes = dbContext.Dishes;
            ViewBag.AllChefs = dbContext.Chefs;
            return View();
        }


        [HttpPost("dishes/new")]
        public IActionResult AddNewDish(Dish newDish)
        {
            Console.WriteLine($"*************************{newDish.ChefId}*************");
            dbContext.Add(newDish);
            dbContext.SaveChanges();
            return RedirectToAction("Dishes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
