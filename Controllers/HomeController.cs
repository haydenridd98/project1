using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace project1.Controllers
{

    // PLEASE DON'T DELETE THIS FILE (looking at nobody in particular)

    public class HomeController : Controller
    {
        // don't be intimidated Caden
        private readonly ILogger<HomeController> _logger;

        // don't worry about this
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // access the index page view
        public IActionResult Index()
        {
            return View();
        }

        // we can add the other views right here






        // privacy page
        public IActionResult Privacy()
        {
            return View();
        }


        // in case of error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
