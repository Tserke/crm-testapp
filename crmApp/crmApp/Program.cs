using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            //var ui = new Ui();
            //var Customer = ui.CreateCustomer();
            //var basket = ui.CreateBasket();

            var dbContext = new CrmAppDbContext();
            dbContext.Database.EnsureCreated();

            // Insert
            var customer = new Customer()
            {
                Name = "unknown customer",
                Sex = 0
            };

            dbContext.Add(customer);
            dbContext.SaveChanges();

            // Select
            var customers = dbContext
                .Set<Customer>()
                .ToList();

            //// Remove one customer
            //dbContext.Remove(customer);
            //dbContext.SaveChanges();

            // Remove all customers
            dbContext.RemoveRange(customers);
            dbContext.SaveChanges();
        }
    }
 }
