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
    // All Hail Hayden
    // all hail hayden Ridd

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

        public IActionResult task()
        {
            return View();
        }

        public IActionResult taskList()
        {
            return View();
        }



        //I deleted the Privacy Page. It didn't deserve to live. We don't believe in privacy. #IloveElon


        // in case of error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
