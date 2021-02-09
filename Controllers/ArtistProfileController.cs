using DSU21_2.Models;
using DSU21_2.Repository;
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
        private readonly IArtDBRepo artDbRepo;
        public ArtistProfileController(IArtDBRepo artDbRepo)
        {
            this.artDbRepo = artDbRepo;
        }
        public async  Task<IActionResult> Index(string profileId, string profileFirstName)
        {
            Artist artist = await artDbRepo.CheckArtist(profileId, profileFirstName);
            ArtistViewModel viewModel = new ArtistViewModel(artist);
            return View(viewModel);
        }
    }
}
