using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5.Data;
using Lab5.Models;
using Lab5.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class DetailController : Controller
    {

        private readonly DataContext dataContext;
        public DetailController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            var categoryItem = dataContext.Categories.FirstOrDefault(p => p.CategoryId == product.CategoryId);
            ViewBag.Category = categoryItem.CategoryName;
            return View(product);
        }
    }
}