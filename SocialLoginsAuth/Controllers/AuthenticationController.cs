using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace SocialLoginsAuth.Controllers
{
    [Route("authentication")]
    public class AuthenticationController : Controller
    {
        [Route("signin")]
        public IActionResult SignIn()
        {
            return View();
        }

        [Route("signin/{provider}")]
        public IActionResult SignIn(string provider, string returnUrl = null)
        {
            var defaultRoute = "/";

            var authenticationProperties = new AuthenticationProperties
            {
                RedirectUri = returnUrl ?? defaultRoute
            };

            return Challenge(authenticationProperties, provider);
        }

        [Route("signout")]
        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }
    }
}
