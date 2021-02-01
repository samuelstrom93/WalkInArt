using DSU21_2.Models;
using DSU21_2.Repository;
using DSU21_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Controllers
{
    public class ChosenCategoryController : Controller
    {
        private IArtDBRepo artDBRepo;

        public ChosenCategoryController(IArtDBRepo artDBRepo)
        {
            this.artDBRepo = artDBRepo;
        }
        [Route("ChosenCategory/{id?}")]
        public async Task<IActionResult> Index(int id)
        {
            var chosenCategory = await artDBRepo.GetTag(id);
            ChosenCategoryViewModel chosenCategoryViewModel = new ChosenCategoryViewModel(chosenCategory);
            return View(chosenCategoryViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
