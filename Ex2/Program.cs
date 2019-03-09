using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Dog
    {
        public string Name;
        public string Race;
        public string Color;

        public Dog (string dogName, string dogRace, string dogColor )
        {
            Name = dogName;
            Race = dogRace;
            Color = dogColor;
        }

        public void Eat()
        {
            Console.WriteLine("The dog "+Name+" is now eating");
        }

        public void Play()
        {
            Console.WriteLine("The dog " + Name + " is now playing ");
        }

        public void ChaseTail()
        {
            Console.WriteLine("The dog " + Name + " is now chaising it's tail");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert: Name of the Dog (blank space) Race of the Dog (blank space) Color of the Dog");
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            Dog doggy = new Dog(array[0], array[1], array[2]);
            Console.WriteLine("Chose action insert 1 (for eating status) or 2 (for playing stats) or 3 (for chasing status");
            Boolean forever = true;
            while (forever)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": doggy.Eat(); break;
                    case "2": doggy.Play(); break;
                    case "3": doggy.ChaseTail(); break;
                    default: forever = false;  break;
                }
            }
        }
    }
}
