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
            //var customer = new Customer()
            //{
            //    Name = "unknown customer",
            //    Sex = 0
            //};

            //var customer1 = new Customer()
            //{
            //    Name = " customer 1",
            //    Sex = 1
            //};


            //var customer2 = new Customer()
            //{
            //    Name = " Customer 2",
            //    Sex = 0
            //};

            //var customer3 = new Customer()
            //{
            //    Name = " Customer 2",
            //    Sex = 0
            //};

            //var customer4 = new Customer()
            //{
            //    Name = " Customer 2",
            //    Sex = 0
            //};

            //dbContext.Add(customer);
            //dbContext.Add(customer1);
            //dbContext.Add(customer2);
            //dbContext.Add(customer3);
            //dbContext.Add(customer4);
            //dbContext.SaveChanges();

            // Select
            var customers = dbContext
                .Set<Customer>()
                .Where(cust => cust.CustomerId == 3)
                .Where(cust => cust.Name == "Customer2")
                .SingleOrDefault();
                //.ToList();

            //// Remove one customer
            //dbContext.Remove(customer);
            //dbContext.SaveChanges();

            // Remove all customers
            //dbContext.RemoveRange(customers);
            //dbContext.SaveChanges();
        }
    }
 }
