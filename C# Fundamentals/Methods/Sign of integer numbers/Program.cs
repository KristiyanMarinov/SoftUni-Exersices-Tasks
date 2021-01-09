using System;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                PositiveNumber(n);
            }
            else if (n == 0)
            {
                Zero(n);
            }
            else
            {
                NegativeNumber(n);
            }

            static void PositiveNumber(int number)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            static void Zero(int number)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            static void NegativeNumber(int number)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}

