using DSU21_2.Models;
using DSU21_2.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArtDBRepo artDbRepo;
        


        public HomeController(ILogger<HomeController> logger, IArtDBRepo artDbRepo)
        {
            _logger = logger;
            this.artDbRepo = artDbRepo;
        }


        public async Task<IActionResult>  Index()
        {
            //Artist a = await artDbRepo.GetArtistAsync(2);
            //artDbRepo.AddCollection(a);
            //artDbRepo.AddArtwork(a.Collections[0]);
            //List<Tag> tags = await artDbRepo.GetTags();
            //var collections = await artDbRepo.GetCollectionsWithArt();
            //Artist artist = await artDbRepo.UpdateArtist(1, "^_^");
            var test = await artDbRepo.GetCollectionWithTag(1);
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
