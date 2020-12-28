using System;
using System.Dynamic;

namespace StudentIformation
{
    class Kris
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (number % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}
