using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Views.Exhibitions
{
    public class ExhibitionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
