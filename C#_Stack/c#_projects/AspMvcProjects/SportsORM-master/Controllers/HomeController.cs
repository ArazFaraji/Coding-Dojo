using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;
using Microsoft.EntityFrameworkCore;

namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context context;

        public HomeController(Context DBContext)
        {
            context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = context.Leagues
                .Where(l => l.Sport.Contains("Baseball"));
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = context.Leagues
                .Where(i => i.Name.Contains("Women"));

            ViewBag.Hockey = context.Leagues
                .Where(i => i.Sport.Contains("Hockey"));

            ViewBag.NotFootball = context.Leagues
                .Where(i => !i.Sport.Contains("Football"));

            ViewBag.Conference = context.Leagues
                .Where(i => i.Name.Contains("Conference"));

            ViewBag.Atlantic = context.Leagues
                .Where(i => i.Name.Contains("Atlantic"));

            ViewBag.Dallas = context.Teams
                .Where(i => i.Location.Contains("Dallas"));

            ViewBag.Raptors = context.Teams
                .Where(i => i.TeamName.Contains("Raptors"));

            ViewBag.City = context.Teams
                .Where(i => i.Location.Contains("City"));

            ViewBag.T = context.Teams
                .Where(i => i.TeamName.Contains("T"));

            ViewBag.AllTeams = context.Teams
                .OrderBy(i => i.TeamName)
                .ThenBy(i => i.Location);

            ViewBag.TeamReversed = context.Teams
                .OrderByDescending(i => i.TeamName);

            ViewBag.Cooper = context.Players
                .Where(i => i.LastName == "Cooper");

            ViewBag.Joshua = context.Players
                .Where(i => i.FirstName == "Joshua");

            ViewBag.NoJoshCoop = context.Players
                .Where(i => i.LastName == "Cooper")
                .Where(i => i.FirstName != "Joshua");

            ViewBag.AlexWyatt = context.Players
                .Where(i => i.FirstName == "Alexander" || i.FirstName=="Wyatt")
                .OrderBy(i => i.FirstName)
                .ThenBy(i => i.LastName);


            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            //...all teams in the Atlantic Soccer Conference
            ViewBag.ASC = context.Teams
                .Include(i => i.CurrLeague)
                .Where(i => i.CurrLeague.Name == "Atlantic Soccer Conference" );

            //...all (current) players on the Boston Penguins
            ViewBag.Penguins = context.Players
                .Include(i => i.CurrentTeam)
                .Where(i => i.CurrentTeam.TeamName == "Penguins");

            //...all (current) players in the International Collegiate Baseball Conference
            ViewBag.ICBC = context.Players
                .Include(i => i.CurrentTeam)
                .ThenInclude(i => i.CurrLeague)
                .Where(i => i.CurrentTeam.CurrLeague.Name.Contains("Collegiate") && i.LastName == "Lopez")
                .OrderBy(i => i.LastName);

            //.all (current) players in the American Conference of Amateur Football with last name "Lopez"
            ViewBag.AMAF = context.Players
                .Include(i => i.CurrentTeam)
                .ThenInclude(i => i.CurrLeague)
                .Where(i => i.CurrentTeam.CurrLeague.Name == "American Conference of Amateur Football")
                .OrderBy(i => i.LastName);

            //all football players
            ViewBag.Football = context.Players
                .Include(i => i.CurrentTeam)
                .ThenInclude(i => i.CurrLeague)
                .Where(i => i.CurrentTeam.CurrLeague.Sport == "Football")
                .OrderBy(i => i.FirstName)
                .ThenBy(i => i.LastName);

            //...all teams with a (current) player named "Sophia"
            // ViewBag.Sophia = context.Teams
            //     .Include(i => i.CurrentPlayers)
            //     // .ThenInclude(i => i.PlayerId)
            //     .Where(i => i.CurrentPlayers.FirstName == "Sophia");

            ViewBag.Sophia = context.Players
                .Where(i => i.FirstName == "Sophia")
                .Include(i => i.CurrentTeam);





            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}