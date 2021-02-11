using DSU21_2.Models;
using DSU21_2.Repository;
using DSU21_2.ViewModels;
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
            //Used for filling local DB with data, run once.
            //await artDbRepo.FillDbWithData();
            var collectionList = await artDbRepo.GetCollectionsWithArt();
            var tagList = await artDbRepo.GetTags();
            var homeViewModel = new HomeViewModel(collectionList, collectionList, tagList);
            return View(homeViewModel);
           
        }

        public async Task<IActionResult> Room3d()
        {
            //Used for filling local DB with data, run once.
            //await artDbRepo.FillDbWithData();
            var collectionList = await artDbRepo.GetCollectionsWithArt();
            var tagList = await artDbRepo.GetTags();
            var homeViewModel = new HomeViewModel(collectionList, collectionList, tagList);
            return PartialView("/Views/Home/Room3d.cshtml",homeViewModel);
        }

        //↓↓↓↓↓↓↓↓↓ TA BORT SENARE ↓↓↓↓↓↓↓↓↓
        [Route("Test0/{id?}")]
        public async Task<IActionResult> Test3D()
        {
            //Used for filling local DB with data, run once.
            //await artDbRepo.FillDbWithData();
            var collectionList = await artDbRepo.GetCollectionsWithArt();
            var tagList = await artDbRepo.GetTags();
            var homeViewModel = new HomeViewModel(collectionList, collectionList, tagList);
            return View(homeViewModel);
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
