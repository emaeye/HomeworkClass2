using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateApp
{
    class Program
    {
        public static Dictionary<string, string> dict = new Dictionary<string, string>();

        public static void Add()
        {
            Console.WriteLine("Please insert state");
            var state = Console.ReadLine();

            var yes = "y";
            
            if (dict.ContainsKey(state))
            {
                Console.WriteLine("state already exists, do you want to overwrite (y/n)?");
                yes = Console.ReadLine();
                if (yes=="y")
                    dict.Remove(state);
            }
            if (yes == "y")
            {
                Console.WriteLine("Please insert state capital");
                var capital = Console.ReadLine();

                dict.Add(state, capital);
            }
        }
        public static void Search()
        {
            Console.WriteLine("Please insert state");

            var state = Console.ReadLine();
            bool check = true;

            foreach (KeyValuePair<string, string> item in dict)
            {
                if (item.Key == state)
                {
                    Console.WriteLine(" Capital of {0} is: {1}", state, item.Value);
                    check = false;
                }

            }
            if (check) Console.WriteLine("no entry for state "+state);

        }
        public static void Print()
        {
            foreach (KeyValuePair<string, string> item in dict)
            {
             Console.WriteLine(" Capital of {0} is {1}", item.Key, item.Value);
            }

        }
        static void Main(string[] args)
        {
            dict.Add("Albania", "Tirana");
            dict.Add("Greece", "Athens");
            dict.Add("Bulgaria", "Sofia");
            dict.Add("Serbia", "Belgrade");

            while (true)
            {
                Console.WriteLine("Please choose action");
                Console.WriteLine("1 - add capital/state pair");
                Console.WriteLine("2 - search capital of state");
                Console.WriteLine("3 - print all capital/state pairs");
                Console.WriteLine("4 - exit");
                var action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1: Add(); break;
                    case 2: Search(); break;
                    case 3: Print(); break;
                    case 4: Environment.Exit(0); break;
                    default: Console.WriteLine("invalid input"); break;
                }
            }
        }
    }
}
