using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab5.Models;
using Lab5.Data;

namespace Lab5.Controllers
{
    public class HomeController : Controller
    {
        readonly DataContext dataContext;
        public HomeController(DataContext dataContext )
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            var item = from p in dataContext.Products
                       select p;
            return View(item.ToList());
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
