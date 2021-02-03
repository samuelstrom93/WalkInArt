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
    public class CategoriesController : Controller
    {
        private IArtDBRepo artDBRepo;

        public CategoriesController(IArtDBRepo artDBRepo)
        {
            this.artDBRepo = artDBRepo;
        }

        public async Task <IActionResult> Index()
        {
            var categories = await artDBRepo.GetTags();
            CategoriesViewModel categoriesViewModel = new CategoriesViewModel(categories);
            return View(categoriesViewModel);
        }


        [Route("Categories/{title}")]
        public async Task<IActionResult> ChosenCategory(string title)
        {
            var chosenCategory = await artDBRepo.GetTagByName(title);
            ChosenCategoryViewModel chosenCategoryViewModel = new ChosenCategoryViewModel(chosenCategory);
            return View(chosenCategoryViewModel);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
