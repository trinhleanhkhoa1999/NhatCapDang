using Lab5.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
            new Category()
            {
                CategoryId = 1,
                CategoryName = "Vegetable"
            },
            new Category()
            {
                CategoryId = 2,
                CategoryName = "Fruit"
            });
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Salas tươi",
                    ProductImage = "salas.jpg",
                    Descriptions = "rau xà lách tươi",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now,
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Salas tươi",
                    ProductImage = "salas.jpg",
                    Descriptions = "rau xà lách tươi",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now,
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Salas tươi",
                    ProductImage = "salas.jpg",
                    Descriptions = "rau xà lách tươi",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now,
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "Chanh dây tươi",
                    ProductImage = "bs2.jpg",
                    Descriptions = "chanh dây tươi",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now,
                    CategoryId = 2
                });
                builder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Name = "Visitor",
                   NormalizedName = "VISITOR"
               },
               new IdentityRole
               {
                   Name = "Administrator",
                   NormalizedName = "ADMINISTRATOR"
               }
               );
            
        }
    }
}
