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
            if(myProduct != null)
            {
                myProduct.Print();

                decimal total = myProduct.TotalCost;
                Console.WriteLine(total);
            }
           
        }
    }
}
