using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Main()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult FormSubmission(Survey sampleSurvey)
        {
            
            return View();
        }


    }
}