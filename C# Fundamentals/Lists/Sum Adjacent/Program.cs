using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();

            List<double> numbers = new List<double>();
            for (int i = 0; i < input.Count; i++)
            {
                numbers.Add(double.Parse(input[i]));
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + 1 < numbers.Count)
                {


                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        i = -1;

                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

