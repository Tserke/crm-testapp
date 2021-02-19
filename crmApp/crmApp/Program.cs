using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            Ui ui = new Ui();

            Customer myCustomer = ui.CreateCustomer();

            Basket basket = new Basket();
            string askUser = "y";
            while (askUser == "y")
            {
                Product product = ui.CreateProduct();
                basket.AddProduct(product);
                Console.WriteLine("Do you want to continue? (y to continue)");
                askUser = Console.ReadLine();
            }
            basket.Print();
            basket.ShowCategories();

            /* this code becomes absolete with the introduction of While loop 
            Product myProduct = ui.CreateProduct();
            //if(myProduct != null)
            //{
            //    myProduct.Print();
            //    decimal total = myProduct.TotalCost;
            //    Console.WriteLine(total);
            //}
            Product myProduct1=ui.CreateProduct();
            Product myProduct2=ui.CreateProduct();
            Basket basket = new Basket();
            basket.AddProduct(myProduct);
            basket.AddProduct(myProduct1);
            basket.AddProduct(myProduct2);
            this code becomes absolete with the introduction of Basket class
            List<Product> products = new List<Product>
            {
                myProduct,
                myProduct1,
                myProduct2
            };
            this code was moves to basker where it belongs
            int howManyHight = 0;
            int howManyMedium = 0;
            int howManyLow = 0;
            foreach (Product p in products)
            {
                Console.WriteLine(p.GetRange());
                if (p.GetRange() == "low") howManyLow++; 
                if (p.GetRange() == "medium") howManyMedium++; 
                if (p.GetRange() == "hight") howManyHight++;

            }

            Console.WriteLine($"howManyLow= {howManyLow}");
            Console.WriteLine($"howManyMedium= {howManyMedium}");
            Console.WriteLine($"howManyHight= {howManyHight}");
            */

        }
    }
}
