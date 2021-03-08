using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    public class CrmAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=localhost,11433;Database=crmapp-db;User Id=sa;Password=Dd680039!;" );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Customer>()
                .ToTable("Customer");

            modelBuilder
                .Entity<Product>()
                .ToTable("Product");
        }
    }
}
