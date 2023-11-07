﻿using CheckBoxesASPCore6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckBoxesASPCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new ViewModel()
            {
               CheckBoxes = new List<CheckBoxOptions> 
               { 
                   new CheckBoxOptions() 
                   {
                       IsChecked = true,
                       Text = "Cricket",
                       Value = "Cricket"
                   },
                   new CheckBoxOptions()
                   {
                       IsChecked = false,
                       Text = "FootBall",
                       Value = "FootBall"
                   },
                   new CheckBoxOptions()
                   {
                       IsChecked = false,
                       Text = "Badminton",
                       Value = "Badminton"
                   }
               }
            };
            return View(model);
        }

        //public IActionResult Index()
        //{
        //    var model = new ViewModel
        //    {
        //        AcceptTerms = false,
        //        Text = "I Accept terms",
        //    };
        //    return View(model);
        //}

        [HttpPost]
        public IActionResult Index(ViewModel data)
        {
            //var value = data.AcceptTerms;
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(ViewModel data)
        //{
        //    var value = data.AcceptTerms;
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}