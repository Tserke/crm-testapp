using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class Ui
    {
        //Factory method
        public Product CreateProduct()
        {
            Product product = new Product();
            //try-catch block to manage user's input 
            try
            {
                Console.WriteLine("Give the code");
                product.Code = Console.ReadLine();
                Console.WriteLine("Give the name");
                product.Name = Console.ReadLine();
                Console.WriteLine("Give the Price");
                product.Price = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Give the quantity");
                product.Quantity = Int32.Parse(Console.ReadLine());

                return product;
            }
            catch (Exception)
            {
                Console.WriteLine("You have not completed the questions properly \n" +
                    " Please try again.");
                return null;
            }

        }

        public Customer CreateCustomer()
        {
            Customer customer = new Customer(); 
            try
            {
                Console.WriteLine("Give the Customer ID");
                customer.CustomerId = Console.ReadLine();
                Console.WriteLine("Give the name");
                customer.Name = Console.ReadLine();
                Console.WriteLine("Give the Last Name");
                customer.LastName = Console.ReadLine();
                Console.WriteLine("Give the Phone");
                customer.Phone = Console.ReadLine();
                Console.WriteLine("Give the Last Email");
                customer.Email = Console.ReadLine();

                return customer;
            }
            catch (Exception)
            {
                Console.WriteLine("You have not completed the questions properly \n" +
                    " Please try again.");
                return null;
            }

        }
        
    }
}
