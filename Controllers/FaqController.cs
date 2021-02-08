using DSU21_2.Models;
using DSU21_2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Controllers
{
    [AllowAnonymous]
    public class FaqController : Controller
    {
        [Route("Faq")]

        public IActionResult Index()
        {        
            FaqViewModel faqViewModel = new FaqViewModel();
            return View(faqViewModel);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }  
}
