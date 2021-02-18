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

            Product myProduct = ui.CreateProduct();
            //if(myProduct != null)
            //{
            //    myProduct.Print();
            //    decimal total = myProduct.TotalCost;
            //    Console.WriteLine(total);
            //}
            
            Product myProduct1=ui.CreateProduct();
            Product myProduct2=ui.CreateProduct();

            List<Product> products = new List<Product>
            {
                myProduct,
                myProduct1,
                myProduct2
            };

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

        }
    }
}
