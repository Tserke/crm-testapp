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
            Customer Customer = ui.CreateCustomer();
            Basket basket = ui.CreateBasket();
            
        }
    }
 }
