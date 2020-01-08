using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;
using Microsoft.AspNetCore.Http;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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


        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbaz = new int[]
            {
                1,2,3,10,43,5
            };
            return View(numbaz);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            string[] userz = new string []
            {
                "Moose Phillips", "Sarah", "Jerry", "Rene Ricky", "Barbarah"
            };
            return View(userz);
        }



        // [HttpGet("numbers")]
        // public IActionResult Numbers()
        // {
        //     Numbers numz = new Numbers()
        //     {
        //         numbaz = new int[]
        //         {
        //             1,2,3,10,43,5
        //         }
        //     };

        //     return View(numz);
        // }
    }
}
