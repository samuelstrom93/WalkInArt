using DSU21_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Controllers
{
    public class ArtistProfileController : Controller
    {
        public IActionResult Index(string profileId, string profileFirstName)
        {
            ArtistViewModel a = new ArtistViewModel(profileId,profileFirstName);
            return View(a);
        }
    }
}
