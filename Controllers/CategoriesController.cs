﻿using DSU21_2.Models;
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
            //var category = await artDBRepo.GetTag(tagId);
            CategoriesViewModel categoriesViewModel = new CategoriesViewModel(categories);
            return View(categoriesViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
