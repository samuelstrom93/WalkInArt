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
        public async Task<IActionResult> Index3d(int id)
        {
            var exhibitions =  await artDbRepo.GetCollection(id);
            var exhibitionsForRoom =  await artDbRepo.GetCollectionsWithArt();
            var artist =  await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return View(exhibitionsViewModel);
        }

        [Route("Exhibitions2/{id?}")]
        public async Task<IActionResult> Index3d_2(int id)
        {
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return View(exhibitionsViewModel);
        }

        [Route("Exhibitions2d/{id?}")]
        public async Task<IActionResult> Index(int id)
        {
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

        public async Task<IActionResult> Room3d_1(int id)
        {
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return PartialView("/views/exhibitions/Room3d_1.cshtml", exhibitionsViewModel);
        }

        public async Task<IActionResult> Room3d_2(int id)
        {
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return PartialView("/views/exhibitions/Room3d_2.cshtml", exhibitionsViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
