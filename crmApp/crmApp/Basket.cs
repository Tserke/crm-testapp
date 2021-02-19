using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class Basket
    {
        //encapsulation (a class that contains other classes as fields) "GR-enthilakosi"
        //public List<Product> Products { get; set; }
        private List<Product> products;
        public Customer Customer { get; set; }

        public Basket()
        {
            products = new List<Product>();
        }

        public void AddProduct (Product product)
        {
            products.Add(product);
        }

        public void Print()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }    
        }

        public void ShowCategories()
        {
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
        
        public decimal TotalCost()
        {
            decimal totalCost = 0;
            foreach (Product p in products)
            {
                totalCost += p.TotalCost;
            }
            return totalCost;
            // the m in 0m means that it is a decimal 0 and not int 
            //return 0m;
        }
    }
}
