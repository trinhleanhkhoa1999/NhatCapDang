using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5.Data;
using Lab5.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;

namespace Lab5.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly DataContext dataContext;
        public OrderController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            var item = from p in dataContext.Orders
                       select p;
            return View(item.ToList());
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Order oldOrder = dataContext.Orders.FirstOrDefault(p => p.OrderId == id);
            return View(oldOrder);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Order order = dataContext.Orders.FirstOrDefault(p => p.OrderId == id);
            dataContext.Orders.Remove(order);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "Order");
        }
        //[HttpGet("Order/{id}/{name}")]
        public IActionResult Detail(int id)
        {
            Order order = dataContext.Orders.FirstOrDefault(p => p.OrderId == id);
            var item = dataContext.OrderDetails.Where(p => p.OrderId == order.OrderId).ToList();
            List<Product> products = new List<Product>();
            foreach (var item2 in item)
            {
                Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == item2.ProductId);
                products.Add(product);
            }
            ViewBag.Total = item.Sum(item => item.Product.ProductPrice * item.Quantity);
            ViewBag.Order = item;
            return View(order);
        }
    }
}
