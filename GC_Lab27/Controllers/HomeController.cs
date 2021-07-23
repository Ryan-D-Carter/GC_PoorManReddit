using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GC_Lab27.Models;

namespace GC_Lab27.Controllers
{
    public class HomeController : Controller
    {
        private readonly AwwDAL _aww = new AwwDAL();

       

        public async Task<IActionResult> Index()
        {
            var aww = await _aww.GetAww();

            return View(aww);
        }

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
