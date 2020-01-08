using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
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
            int? SessionUserId = HttpContext.Session.GetInt32("UserID");
            if (SessionUserId != null)
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpPost("RegisterNewUser")]
        public IActionResult RegisterNewUser(User newUser)
        {
            HttpContext.Session.Clear();
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                dbContext.Add(newUser);
                dbContext.SaveChanges();

                HttpContext.Session.SetInt32("UserID", newUser.UserId);
                return Redirect("Dashboard");
            }
            return View("Index");
        }

        [HttpPost("LoginVerification")]
        public IActionResult LoginVerification(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserID", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Login");
        }

        [HttpGet("NewWedding")]
        public IActionResult NewWedding()
        {
            return View();
        }


        [HttpPost("AddNewWedding")]
        public IActionResult AddNewWedding(Wedding newWedding)
        {
            int? SessionUserId = HttpContext.Session.GetInt32("UserID");
            if(newWedding.Date < DateTime.Now)
            {
                ModelState.AddModelError("Date", "Date must be in the future.");
            }

            newWedding.UserId = (int) SessionUserId;

            dbContext.Add(newWedding);
            dbContext.SaveChanges();

            return Redirect($"WeddingInfo/{newWedding.WeddingId}");
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            int? SessionUserId = HttpContext.Session.GetInt32("UserID");
            
            ViewBag.AllWeddings = dbContext.Weddings
            .Include(a => a.Attendees)
            .Include(a => a.Creator);
            if(SessionUserId == null)
            {
                HttpContext.Session.Clear();
                return View("Index");
            }

            ViewBag.User = dbContext.Users.FirstOrDefault(u => u.UserId == SessionUserId);
            
            return View();
        }

        [HttpGet("WeddingInfo/{WeddingID}")]
        public IActionResult WeddingInfo(int WeddingID)
        {
            int? SessionUserId = HttpContext.Session.GetInt32("UserID");
            if(SessionUserId == null)
            {
                HttpContext.Session.Clear();
                return View("Index");
            }


            ViewBag.Wedding = dbContext.Weddings
            .FirstOrDefault(w => w.WeddingId == WeddingID);

            ViewBag.GuestList = dbContext.Guests
            .Include(i => i.Attendee)
            .Where(w => w.WeddingId == WeddingID);

            return View();
        }

        [HttpGet("RSVP/{WeddingID}")]
        public IActionResult RSVP(int WeddingID)
        {
            int? SessionUserId = HttpContext.Session.GetInt32("UserID");

            Guest newGuest = new Guest();
            newGuest.UserId = (int)SessionUserId;
            newGuest.WeddingId = WeddingID;

            dbContext.Add(newGuest);
            dbContext.SaveChanges();

            
            return RedirectToAction("Dashboard");
        }

        [HttpGet("UnRSVP/{WeddingID}")]
        public IActionResult UnRSVP(int WeddingID)
        {
            int? SessionUserId = HttpContext.Session.GetInt32("UserID");

            Guest guestToRemove = dbContext.Guests.Where(g => g.WeddingId == WeddingID).FirstOrDefault(u => u.UserId == (int) SessionUserId);

            dbContext.Remove(guestToRemove);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");

        }

        [HttpGet("delete/{WeddingId}")]
        public IActionResult Delete(int WeddingId)
        {

           Wedding weddingToDelete = dbContext.Weddings
           .SingleOrDefault(i => i.WeddingId == WeddingId);

            dbContext.Remove(weddingToDelete);
            dbContext.SaveChanges();
            return Redirect("/dashboard");
        }
        
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
