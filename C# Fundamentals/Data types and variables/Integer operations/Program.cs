using System;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int sum = first + second;
            int divide = (sum / third);
            int multiply = divide * fourth;
            Console.WriteLine(multiply);
        }
    }
}

