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

        public int Menu()
        {
            Console.WriteLine("1. Add a product 2. Display basket 3. Show Categories 4. Total Cost 5. Save 6. Load 0. Exit ");
            Console.WriteLine("Insert your choice");
            int choice = 0;
            try
            {
                choice = Int32.Parse(Console.ReadLine()); //Int32.Parse is used to translate the sting inserted by the user in to an int
            }
            catch(Exception)
            {

            }

            return choice;
        }

        public Customer CreateCustomer()
        {
            Customer customer = new Customer();
            try
            {
                Console.WriteLine("Give the Customer ID");
                customer.CustomerId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Give the name");
                customer.Name = Console.ReadLine();
                Console.WriteLine("Give Sex");
                customer.Sex = Int32.Parse(Console.ReadLine());
                //Console.WriteLine("Give the Last Name");
                //customer.LastName = Console.ReadLine();
                //Console.WriteLine("Give the Phone");
                //customer.Phone = Console.ReadLine();
                //Console.WriteLine("Give the Last Email");
                //customer.Email = Console.ReadLine();

                return customer;
            }
            catch (Exception)
            {
                Console.WriteLine("You have not completed the questions properly \n" +
                    " Please try again.");
                return null;
            }

        }

        public Basket CreateBasket()
        {
            Basket basket= new Basket();
            int choice;
            //basket.Load("basket.txt"); if we add this line the program will load the last saved basket this can be used for automation purposes
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Product product = CreateProduct();
                        basket.AddProduct(product);
                        break;
                    case 2:
                        basket.Print();
                        break;
                    case 3:
                        basket.ShowCategories();
                        break;
                    case 4:
                        Console.WriteLine("Total cost= " + basket.TotalCost());
                        break;
                    case 5:
                        basket.Save("basket.txt");
                        break;
                    case 6:
                        basket.Load("basket.txt");
                        break;
                    case 0:
                        Console.WriteLine("You selected to exit");
                        //basket.Save("basket.txt"); if this line is added the program will save the bakset before exit this can be used for automation purposes
                        break;
                }
            }
            while (choice != 0);
            return basket;
        }
    }
}
