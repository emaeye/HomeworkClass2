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
            bool correctInput = true;
            string decision;
            string[] result = new string[] {};
            int index = 0;
            //Start:
            while (correctInput)
            {

                Array.Resize(ref result, result.Length + 1);
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
                if ((!checkNumber1 || !checkNumber2) || (input == "/" && num2 == 0 ))
                {
                    Console.WriteLine("Invalid input number or you are trying to divide with 0, please try again ");
                    continue;
               
                }

                switch (input)
                {
                    case "+":
                        Console.WriteLine("The result is: " + (num1 + num2));
                        result[index] = num1 + "+" + num2 + "=" + (num1 + num2);
                        index++;
                        Console.WriteLine("To continue with calculations press Y and to abort press N");
                        decision = Console.ReadLine();
                        if (decision == "N")
                        {
                            Console.WriteLine("Calculations END's with your calculation history");
                            for (int i=0; i<result.Length; i++)
                            {
                                Console.WriteLine(result[i]);
                            }
                            correctInput = false;
                            break;
                        }
                        continue;
                    case "-":
                        
                        Console.WriteLine("The result is: " + (num1 - num2));
                        result[index] = num1 + "-" + num2 + "=" + (num1 - num2);
                        index++;
                        Console.WriteLine("To continue with calculations press Y and to abort press N");
                        decision = Console.ReadLine();
                        if (decision == "N")
                        {
                            Console.WriteLine("Calculations END's with your calculation history");
                            for (int i = 0; i < result.Length; i++)
                            {
                                Console.WriteLine(result[i]);
                            }
                            correctInput = false;
                            break;
                        }
                        continue;

                    case "*":
                        Console.WriteLine("The result is: " + (num1 * num2));
                        result[index] = num1 + "*" + num2 + "=" + (num1 * num2);
                        index++;
                        Console.WriteLine("To continue with calculations press Y and to abort press N");
                        decision = Console.ReadLine();
                        if (decision == "N")
                        {
                            Console.WriteLine("Calculations END's with your calculation history");
                            for (int i = 0; i < result.Length; i++)
                            {
                                Console.WriteLine(result[i]);
                            }
                            correctInput = false;
                            break;
                        }
                        continue;

                    case "/":
                        Console.WriteLine("The result is: " + (num1 / num2));
                        result[index] = num1 + "/" + num2 + "=" + (num1 / num2);
                        index++;
                        Console.WriteLine("To continue with calculations press Y and to abort press N");
                        decision = Console.ReadLine();
                        if (decision == "N")
                        {
                            Console.WriteLine("Calculations END's with your calculation history");
                            for (int i = 0; i < result.Length; i++)
                            {
                                Console.WriteLine(result[i]);
                            }
                            correctInput = false;
                            break;
                        }
                        continue;

                    default:
                        Console.WriteLine("Invaild operator selected, please try again ");
                        continue;
                }
            }

            Console.ReadLine();        
        }

    }
}
