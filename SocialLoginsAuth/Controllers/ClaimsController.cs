using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialLoginsAuth.Models;

namespace SocialLoginsAuth.Controllers
{
    [Route("claims")]
    public class ClaimsController : Controller
    {
        [Route("")]
        [Authorize]
        public IActionResult Index()
        {
            var vm = new ClaimsViewModel
            {
                Claims = User.Claims,
                Name = User.Identity.Name
            };

            return View(vm);
        }
    }
}
