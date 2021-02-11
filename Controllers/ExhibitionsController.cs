using DSU21_2.Models;
using DSU21_2.Repository;
using DSU21_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Views.Exhibitions
{
    [AllowAnonymous]
    public class ExhibitionsController : Controller
    {
        private readonly IArtDBRepo artDbRepo;

        public ExhibitionsController(IArtDBRepo artDbRepo)
        {
            this.artDbRepo = artDbRepo;
        }

        [Route("Exhibitions/{id?}")]
        public async Task<IActionResult> Index(int id)
        {
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return View(exhibitionsViewModel);
        }

        public async Task<IActionResult> Room3d(int id)
        {
            //id = 2; //TA BORT SENARE
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return View(exhibitionsViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //↓↓↓↓↓↓↓↓↓ TA BORT SENARE ↓↓↓↓↓↓↓↓↓
        [Route("Test/{id?}")]
        public async Task<IActionResult> TestIndex(int id)
        {
            id = 2;
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return View(exhibitionsViewModel);
        }
        [Route("AllExhibitions/{id?}")]
        public async Task<IActionResult> AllExhibitions(int id)
        {
            var allExhibitions = await artDbRepo.GetCollectionsWithArt();         
            AllExhibitionsViewModel AllExhibitionsViewModel = new AllExhibitionsViewModel(allExhibitions);
            return View(AllExhibitionsViewModel);
        }
    }

    
}
