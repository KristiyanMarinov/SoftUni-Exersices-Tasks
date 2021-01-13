using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int number = input.Count / 2;
            for (int i = 0; i < number; i++)
            {
                input[i] += input[input.Count - 1];
                input.Remove(input[input.Count - 1]);
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

