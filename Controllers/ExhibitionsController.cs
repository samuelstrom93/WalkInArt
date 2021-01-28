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
        public async Task<IActionResult>  Index(string id = "")
        {
            var exhibitions = await artDbRepo.GetCollection(int.Parse(id));
            var exhibitionsViewModel = new ExhibitionsViewModel(exhibitions);
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
