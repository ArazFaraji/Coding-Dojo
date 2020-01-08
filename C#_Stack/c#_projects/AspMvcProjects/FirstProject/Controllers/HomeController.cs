using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstProject
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public ViewResult Index()
        {
            // Looks for file called Index.cshtml. First in the name of the controllers views directory. (Views/Home/HiThere.cshtml)
            DateTime CurrentDateTime = DateTime.Now;
            ViewBag.Date = CurrentDateTime.Date.ToString("dddd, dd MMMM yyyy");
            ViewBag.Time = CurrentDateTime.ToString("hh:mm tt");
            return View();
        }

        // localhost:5000/hello
        [HttpGet("hello")]
        public RedirectToActionResult Hello()
        {
            Console.WriteLine("Hello There, redirecting...");
            var param = new{username="Devon", location="Seattle"};
            return RedirectToAction("HelloUser", param);
        }

        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            return $"Hello {username} from {location}";
        }

        // public JsonResult HelloUser(string username, string location)
        // {
        //     var response = new{user=username, place=location};
        //     return Json(response);
        // }
    }
}