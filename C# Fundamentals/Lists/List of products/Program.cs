using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> numbers = new List<int>();
            for (int i = 0; i < Math.Min(input1.Count, input2.Count); i++)
            {
                numbers.Add(input1[i]);
                numbers.Add(input2[i]);
            }
            for (int i = Math.Min(input1.Count, input2.Count); i < Math.Max(input1.Count, input2.Count); i++)
            {
                if (input1.Count > input2.Count)
                {
                    numbers.Add(input1[i]);
                }
                else
                {
                    numbers.Add(input2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
