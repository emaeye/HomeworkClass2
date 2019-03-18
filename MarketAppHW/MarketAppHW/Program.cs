using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketAppHW.Classes;

namespace MarketAppHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter personal info: Name, Last Name,");
            Person b = new Person("Kale","Veli", new DateTime(2019, 04, 17), 17042009, true);
            // create Products
            Product[] availableProducts = new Product[1];
            availableProducts[0] = new Product("milk", 12345, "dairy", "mkd", true, 34);
            // start buying
            Cart c = new Cart(123,b);
            bool forever = true;
            while (forever)
            {
                Console.WriteLine("choose product:");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i > availableProducts.Length - 1)
                {
                    forever = false;
                }
                else
                {
                    // add product to cart
                    c.addItem(availableProducts[i]);
                }
            }
            // create cashier
            Person cashier = new Person("Kale2", "Veli", new DateTime(2019, 04, 17), 170420092, true);
            // start payment
            double price = c.pay(cashier);

        }
    }
}
