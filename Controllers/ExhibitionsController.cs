﻿using DSU21_2.Models;
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
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return View(exhibitionsViewModel);
        }

        public async Task<IActionResult> Room3d_1(int id)
        {
            id = 2; //TA BORT SENARE
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return PartialView("/views/exhibitions/Room3d_1.cshtml",exhibitionsViewModel);
        }

        public async Task<IActionResult> Room3d_2(int id)
        {
            id = 3; //TA BORT SENARE
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
        //↓↓↓↓↓↓↓↓↓ TA BORT SENARE ↓↓↓↓↓↓↓↓↓
        [Route("Test2/{id?}")]
        public async Task<IActionResult> Index3d(int id)
        {
            id = 2; //TA BORT SENARE
            var exhibitions = await artDbRepo.GetCollection(id);
            var exhibitionsForRoom = await artDbRepo.GetCollectionsWithArt();
            var artist = await artDbRepo.GetArtistByCollection(exhibitions);
            ExhibitionsViewModel exhibitionsViewModel = new ExhibitionsViewModel(exhibitions, exhibitionsForRoom, artist);
            return View(exhibitionsViewModel);
        }

    }

}
