using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    public class Product
    {
        public int Category { get; set; }
        public String ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        //constructors
        //constructor overloading
        public Product(int _category)
        {
            Category = _category;
        }
        //default constructor or empty
        public Product()
        {

        }
        //Method ToString inherented by the Object class
        public override string ToString()
        {
            return $"Name={Name} Price={Price}";
        }
        public void IncreasePrice(decimal percentage)
        {
            if (Category == 1)
            {
                Price *= (1 + 0.1m);
            }
            else
            {
                Price *= (1 + percentage);
            }
        }
        public string GetRange()
        {
            if ( Price < 1)
                return "low";
            else if (Price < 10)
                return "medium";
            else
                return "hight";
        }
    }
}
