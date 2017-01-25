
using Microsoft.AspNetCore.Mvc;
using System;
using Eugene.Models;

namespace Eugene.Controllers
{
    
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                ViewBag.Date = DateTime.Now.ToString("MM/dd/yyyy");
                return View();
            }

            public IActionResult About()
            {
                return View();
            }

            public IActionResult Contact()
            {
                return View();
            }

            public IActionResult History()
            {
                return View();
            }
        }
    }