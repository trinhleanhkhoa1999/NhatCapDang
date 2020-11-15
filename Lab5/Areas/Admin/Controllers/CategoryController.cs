using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5.Data;
using Lab5.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly DataContext dataContext;
        public CategoryController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            var item = from p in dataContext.Categories
                       select p;
            return View(item.ToList());
        }
        [HttpGet]
        public IActionResult Add()
        {
            Category category = new Category();
            return View(category);
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            Category newCategory = new Category();
            if (ModelState.IsValid)
            {
                newCategory.CategoryName = category.CategoryName;
                dataContext.Categories.Add(newCategory);
                dataContext.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category category = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category, int id)
        {
            if(ModelState.IsValid)
            {
                Category newCategory = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
                newCategory.CategoryName = category.CategoryName;
                dataContext.SaveChanges();
                ViewBag.Status = 1;
                return View(newCategory);
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Category oldCategory = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
            return View(oldCategory);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Category category = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
            dataContext.Categories.Remove(category);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
        public IActionResult Detail(int id)
        {
            Category category = dataContext.Categories.FirstOrDefault(p => p.CategoryId == id);
            var item = dataContext.Products.Where(p => p.CategoryId == id).ToList();
            List<Product> products = new List<Product>();
            foreach (var item2 in item)
            {
                Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == item2.ProductId);
                products.Add(product);
            }
            ViewBag.Category = products.ToList();
            return View(category);
        }
    }
}
