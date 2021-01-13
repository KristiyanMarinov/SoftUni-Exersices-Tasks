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

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < 0)
                {
                    input.RemoveAt(i);
                    i -= 1;
                }
            }
            if (input.Count > 0)

            {
                input.Reverse();
                Console.WriteLine(string.Join(" ", input));
            }
            else
            {
                Console.WriteLine("empty");
            }


        }
    }
}
