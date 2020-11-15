using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab5.Data;
using Lab5.Models;
using Lab5.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    [Route("Admin/[controller]/[action]")]
    public class ProductController : Controller
    {
        private readonly DataContext dataContext;
        
        public ProductController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
       
        public IActionResult Index()
        {
            var item = from p in dataContext.Products
                       select p;
            return View(item.ToList());
        }
        [HttpGet]
        public IActionResult Add()
        {
            Product product = new Product();
            var item = (from p in dataContext.Categories
                       select p).ToList();
            ViewBag.Category = item;
            ViewBag.Selected = new SelectList(item, "CategoryId", "CategoryName");
            return View(product);
        }
        [HttpPost]
        public IActionResult Add(Product product, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                Product newProduct = new Product();
                if (photo == null || photo.Length == 0)
                {
                    newProduct.ProductImage = "salas.jpg";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    newProduct.ProductImage = photo.FileName;
                }
                newProduct.ProductName = product.ProductName;
                newProduct.ProductQuantity = product.ProductQuantity;
                newProduct.ProductPrice = product.ProductPrice;
                newProduct.CreateDate = DateTime.Now;
                newProduct.CategoryId = product.CategoryId;
                dataContext.Products.Add(newProduct);
                dataContext.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                var item = (from p in dataContext.Categories
                            select p).ToList();
                ViewBag.Selected = new SelectList(item, "CategoryId", "CategoryName");
                return View(product);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                Product oldProduct = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
                oldProduct.ProductName = product.ProductName;
                oldProduct.ProductQuantity = product.ProductQuantity;
                oldProduct.ProductPrice = product.ProductPrice;
                oldProduct.Descriptions = product.Descriptions;
                oldProduct.CreateDate = DateTime.Now;
                dataContext.SaveChanges();
                ViewBag.Status = 1;
                return View(oldProduct);

            }
            return View(product);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product oldProduct = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            return View(oldProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            dataContext.Products.Remove(product);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
    }
}