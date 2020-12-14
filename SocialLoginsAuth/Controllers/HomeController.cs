using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SocialLoginsAuth.Models;

namespace SocialLoginsAuth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            var errorViewModel = new ErrorViewModel
            {
                RequestId = requestId
            };

            return View(errorViewModel);
        }
    }
}
