using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrmApp
{
    public class Basket
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

        //saves all the data in a file
        public string Save(string filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename, true); //The true means append
                foreach (Product product in products)
                {
                    sw.WriteLine(product.Code + "," + product.Name + "," + product.Price + "," + product.Quantity);
                }
                sw.Close();
            }
            catch(Exception)
            {
                return "An error accured";
            }
            return "The data have been saved";
        }
        
        // reads data from a existing file
        public string Load(string filename)
        {
            try
            {
                products.Clear();
                StreamReader sr = new StreamReader(filename);
                string line;
                line = sr.ReadLine();
                while (line!=null)
                {
                    string[] words = line.Split(",");
                    Product product = new Product {  
                        Code = words[0],
                        Name = words[1],
                        Price = Decimal.Parse(words[2]),
                        Quantity = Int32.Parse(words[3])
                          
                    };
                    products.Add(product);
                    line = sr.ReadLine();
                }
            }
            catch(Exception)
            {
                return "An error occured";
            }
            return "File loaded";
        }
    }
}
