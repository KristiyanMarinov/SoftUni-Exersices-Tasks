using System;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += number % 10;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
}

