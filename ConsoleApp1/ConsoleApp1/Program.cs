using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            //Start:
            Console.WriteLine("Welcome to Real Calculator! press Enter to begin");
            Console.ReadLine();
           
            Console.WriteLine("Please insert one of the following operators: +, -, *, /");
            string input = Console.ReadLine();
            Console.WriteLine("Please insert first number");
            int num1;
            bool checkNumber1 = Int32.TryParse(Console.ReadLine(),out num1);
            Console.WriteLine("Please insert second number");
            int num2;
            bool checkNumber2 = Int32.TryParse(Console.ReadLine(), out num2);
            if (!checkNumber1 || !checkNumber2)
            {
                Console.WriteLine("Invalid input number please try again - Calculations ENDs");
                //goto Start;
            }
            
            switch (input)
            {
                case "+":
                    Console.WriteLine("The result is: " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine("The result is: " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine("The result is: " + (num1 * num2));
                    break;

                case "/":
                    Console.WriteLine("The result is: " + (num1 / num2));
                    break;

                default :
                    Console.WriteLine("Invaild operator selected, please try again - Calculation ENDs ");
                    //goto Start;
                    break;
                    
            }

            Console.ReadLine();        
        }

    }
}
