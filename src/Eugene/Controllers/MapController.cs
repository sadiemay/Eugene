using Microsoft.AspNetCore.Mvc;
using Eugene.Models;
using System;


namespace Eugene.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
