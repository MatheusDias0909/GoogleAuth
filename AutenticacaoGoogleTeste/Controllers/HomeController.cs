using System.Diagnostics;
using AutenticacaoGoogleTeste.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoGoogleTeste.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("Home/testEmail/{userEmail}/{verifiedUser}/{userName}")]
        public IActionResult testEmail(string userEmail, bool verifiedUser, string userName)
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
    }
}