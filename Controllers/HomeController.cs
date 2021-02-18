using DSU21_2.Models;
using DSU21_2.Repository;
using DSU21_2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DSU21_2.Controllers
{

    public class HomeController : Controller
    {
        private readonly IArtDBRepo artDbRepo;
        
        public HomeController(IArtDBRepo artDbRepo)
        {
            this.artDbRepo = artDbRepo;
        }

        [AllowAnonymous]
        public async Task<IActionResult>  Index()
        {
            var collectionList = await artDbRepo.GetCollectionsWithArt();
            var tagList = await artDbRepo.GetTags();
            var homeViewModel = new HomeViewModel(collectionList, collectionList, tagList);
            return View(homeViewModel);
           
        }

        public async Task<IActionResult> Room3d()
        {
            var collectionList = await artDbRepo.GetCollectionsWithArt();
            var tagList = await artDbRepo.GetTags();
            var homeViewModel = new HomeViewModel(collectionList, collectionList, tagList);
            return PartialView("/Views/Home/Room3d.cshtml",homeViewModel);
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
