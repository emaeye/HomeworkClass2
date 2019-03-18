using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppHW.Classes
{
    public class Product
    {
        public string Name;
        public int SN;
        public string Descrip;
        public string Declar;
        public bool adultProduct;
        public double price;

        public Product(string name, int serial, string description, string declaration, bool aP, double p)
        {
            Name = name;
            SN = serial;
            Descrip = description;
            Declar = declaration;
            adultProduct = aP;
            price = p;
        }
        public string getName()
        {
            return Name;
        }
        public double getPrice()
        {
            return price;
        }
        public bool getAdultType()
        {
            return adultProduct;
        }
    }
}
