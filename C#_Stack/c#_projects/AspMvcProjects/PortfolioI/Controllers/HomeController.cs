using Microsoft.AspNetCore.Mvc;
namespace PortfolioI
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Home()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}