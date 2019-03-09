using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Human
    {
        public string FirstName;
        public string LastName;
        public string Age;

        public string GetPersonInfo()
        {
            return FirstName + " "+ LastName + " " + Age;
        }

        //public Human( string fName, string lName, string age)
        //{

        //    FirstName = fName;
        //    LastName = lName;
        //    Age = age;

        //}
        
    }

    


    class Program
    {
        static void Main(string[] args)
        {

            //var human1 = new Human("Emi", "Fili", "42");
            Console.WriteLine("Insert human name");
            var human1 = new Human();
            human1.FirstName = Console.ReadLine();
            Console.WriteLine("Insert human lastname");
            human1.LastName = Console.ReadLine();
            Console.WriteLine("Insert human age");

            human1.Age = Console.ReadLine();

                       
            Console.WriteLine(human1.GetPersonInfo());


            Console.ReadLine();
            
        }
    }
}
