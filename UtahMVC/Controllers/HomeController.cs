using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UtahMVC.Models;

namespace UtahMVC.Controllers
{
    public class HomeController : Controller
    {

        private CrashesDbContext context { get; set; }

        public HomeController(CrashesDbContext temp)
        {
            context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Crashes()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var crash = context.Crashes.Single(x => x.CRASH_ID == id);

            return View(crash);
        }

    }
}
