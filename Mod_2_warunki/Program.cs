using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace Mod_2_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            //exercise 1
            Console.WriteLine("Exercise 1 - equal numbers");
            Console.WriteLine("Enter the first number");
            isValidInput = false;
            double x = 0.0;
            while (!isValidInput)
            {
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only numbers.");
                }
            }
            Console.WriteLine("Enter the second number");
            isValidInput = false;
            double y = 0.0;
            while (!isValidInput)
            {
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only numbers.");
                }
            }
            if(x == y)
            {
                Console.WriteLine($"{x} and {y} are equal");
            }
            else
            {
                Console.WriteLine($"{x} and {y} are different");
            }

            //exercise 2
            Console.WriteLine("Exercise 2 - even/odd");
            Console.WriteLine("Enter a number");
            isValidInput = false;
            double z = 0.0;
            while (!isValidInput)
            {
                
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only numbers.");
                }
            }
            if ((z%2)==0 )
            {
                Console.WriteLine($"{z} is an even number");
            }
            else
            {
                Console.WriteLine($"{z} is an odd number");
            }


            //exercise 3
            Console.WriteLine("Exercise 3 - positive/negative number");
            Console.WriteLine("Enter a number");
            isValidInput = false;
            double v = 0.0;
            while (!isValidInput)
            {
                if (double.TryParse(Console.ReadLine(), out v))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only numbers.");
                }
            }
            if (v > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (v < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // exercise 4.
            Console.WriteLine("Exercise 4 - Leap year");
            Console.WriteLine("Enter a year e.g: 2012");
            
                isValidInput = false;
            int year = 0;
            while (!isValidInput)
            {
                if (int.TryParse(Console.ReadLine(), out year))
                {
                    if (year > 0)
                    {
                        isValidInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only numbers.");
                }
            }
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
                Console.ReadKey();
        }
    }
}
