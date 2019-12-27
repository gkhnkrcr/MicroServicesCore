using MicroServices.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServices.DBContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category
                {
                    Description = "Electronic Items",
                    Id = 1,
                    Name = "Electronics"

                },
                new Category
                {
                    Description = "Dresses",
                    Id = 2,
                    Name = "Clothes"

                },
                new Category
                {
                    Description = "Grocery Items",
                    Id = 3,
                    Name = "Grocery"

                }
                );
        }
    }
}
