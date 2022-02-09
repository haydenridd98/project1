using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private TaskListContext arContext { get; set; }

        public HomeController(TaskListContext someName)
        {
            arContext = someName;
        }

        
        // access the index page view
        public IActionResult Index()
        {
            return View();
        }

        // we can add the other views right here


        [HttpGet]
        public IActionResult Task()
        {
            ViewBag.Categories = arContext.Categories.ToList();

            return View();
        }


        [HttpPost]
        public IActionResult Task(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                arContext.Add(ar);
                arContext.SaveChanges();
                return View();
            }

            else
            {
                return View(ar);
            }

        }


        [HttpGet]
        public IActionResult TaskList()
        {
            var tasks = arContext.responses
                .Include(x => x.Category)
                .ToList();
            return View(tasks);
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
