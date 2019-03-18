using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppHW.Classes
{
    public class Cart
    {
        public int CartSN;
        public Product[] ProductList;
        public Person buyer;
        public Person cashier;

        public Cart( int serial, Person b)
        {
            CartSN = serial;
            buyer = b;
        }
        public void addItem(Product p)
        {
            ProductList[ProductList.Length] = p;
        }
        public string getProductList()
        {
            string list = "";
            foreach (Product p in ProductList){
                list += p.getName();
                list += ',';
            }
            if (list[list.Length - 1] == ',')
                list = list.Substring(0, list.Length - 2);
            return list;
        }
        public double pay(Person c)
        {
            cashier = c;
            buyer.introduce();
            // validate 18
            bool ok = true;
            double sum=0;
            foreach (Product p in ProductList)
            {
                if (p.getAdultType() && (buyer.getAge() < 18))
                {
                        Console.WriteLine("buyer is under 18 and can not buy product: " + p.getName());
                        ok = false;
                        sum -= p.getPrice();
                }
                sum += p.getPrice();
            }
            if (ok)
                Console.WriteLine("all products have been validated");
            Console.WriteLine("total price for all products is: " + sum + "$");
            if (sum > 50)
            {
                double discount = sum * 0.1;
                Console.WriteLine("discount: " + discount + "$");
                sum -= discount;
            }
            if (buyer.isLoyal())
            {
                double discount = sum * 0.15;
                Console.WriteLine("loyalty discount: " + discount + "$");
                sum -= discount;
            }
            else Console.WriteLine("no loyalty discount");
            Console.WriteLine("total sum to be paid by customer: " + sum + "$");
            return sum;
        }
    }
}
