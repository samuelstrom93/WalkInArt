using DSU21_2.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Controllers
{
    [AllowAnonymous, Route("account")]
    public class AccountController : Controller
    {
        [Route("google-login")]
        public ActionResult Index()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("GoogleResponse") };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }


        [Route("google-response")]
        public async Task<IActionResult> GoogleResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var claims = result.Principal.Identities
            .FirstOrDefault().Claims.Select(claim => new
            {
                claim.Value
            }).ToList();

            return RedirectToAction("Index", "ArtistProfile", new { profileId = claims[0].Value , profileFirstName = claims[2].Value});
        }

        [Route("google-logout")]
        public async Task<IActionResult> GoogleLogout()
        {
            await HttpContext.SignOutAsync("Cookies");
            return RedirectToAction("Index", "Home");
        }

    }
}
