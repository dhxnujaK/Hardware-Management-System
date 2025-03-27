using Hardware_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hardware_Management_System
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQLite database file will be created in the project's output directory
            optionsBuilder.UseSqlite("Data Source=HardwareManagement.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Optional: Seed initial data (e.g., categories)
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Portland Cement", Category = "Cement", QuantityInStock = 100, CostPrice = 300, SellingPrice = 400 },
                new Product { ProductId = 2, Name = "Steel Rod (10mm)", Category = "Steel Rods", QuantityInStock = 200, CostPrice = 50, SellingPrice = 70 }
            );
        }
    }
}
