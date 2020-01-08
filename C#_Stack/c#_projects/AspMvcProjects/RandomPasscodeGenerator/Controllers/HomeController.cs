using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscodeGenerator.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscodeGenerator.Controllers
{
    public class HomeController : Controller
    {
        public static int Counter = 0;
        public IActionResult Index()
        {
            
            ViewBag.RandomString = KeyGenerator.GetUniqueKey(15);
            HttpContext.Session.SetInt32("Count", Counter);
            Counter += 1;
            ViewBag.Counter = Counter;
            
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
