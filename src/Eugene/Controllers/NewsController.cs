
using Microsoft.AspNetCore.Mvc;
using Eugene.Models;
using System;

namespace Eugene.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Today()
        {
            News[] todaysEvents = {
                    new News {Title = "Title1",  Story = "story1" },
                    new News {Title = "Title2",  Story = "story2" },
                    new News {Title = "Title3",  Story = "story3" },
                    new News {Title = "Title4",  Story = "story4" }
                };
            return View();
        }
        public IActionResult Archive()
        {
            return View();
        }
    }
}