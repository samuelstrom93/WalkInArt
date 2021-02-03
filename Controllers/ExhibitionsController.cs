using DSU21_2.Models;
using DSU21_2.Repository;
using DSU21_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Views.Exhibitions
{
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
            //id = 2; //TA BORT SENARE
            var exhibition = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibition);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibition, exhibitionsForRoom, artist);
            return View(exhibitionsViewModel);
        }

        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    
}
