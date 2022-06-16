using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class GreetingsController : Controller
    {
        [HttpGet("Greetings/{firstname}")]
        public IActionResult EncryptString(string firstname)
        {
            return Ok($"Hello {firstname}! Greetings from the Hello World App!");
        }
    }
}
