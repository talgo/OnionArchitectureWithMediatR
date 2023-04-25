using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Test1",
                    Quantity = 1,
                    Value = 10.5m,
                }, new Product()
                {
                    Id = 1,
                    Name = "Test2",
                    Quantity = 10,
                    Value = 10.5m,
                }, new Product()
                {
                    Id = 1,
                    Name = "Test3",
                    Quantity = 5,
                    Value = 10.5m,
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
