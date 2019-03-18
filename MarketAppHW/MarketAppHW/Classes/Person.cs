using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppHW.Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DOB;
        public int SSN;
        public bool LoyalityCard;
        public bool status;

        public Person(string name, string lName, DateTime birth, int socialNumber, bool lCard)
        {
            FirstName = name;
            LastName = lName;
            DOB = birth;
            SSN = socialNumber;
            LoyalityCard = lCard;
            status = Buyer();
        }

        public bool Buyer()
        {
            bool buying = false;
            Console.WriteLine("If you are buyer enter: y else enter:n");
            string checkStatus = Console.ReadLine();
            if (checkStatus == "y") buying = true;
            return buying ;
        }

        public void introduce()
        {
            Console.WriteLine("Hello, I'm " + FirstName + " " + LastName);
        }
        public bool isLoyal()
        {
            return LoyalityCard;
        }
        public double getAge()
        {
            return (DateTime.Today - DOB).TotalDays / 365;
        }
    }
}
