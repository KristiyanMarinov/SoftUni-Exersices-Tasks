usiusing System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == command[0])
                {

                    int startIndex = i - command[1];
                    int endIndex = i + command[1];
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    int count = endIndex - startIndex + 1;
                    input.RemoveRange(startIndex, count);
                    i = startIndex - 1;
                }
            }
            int sum = input.Sum();

            Console.WriteLine(sum);
        }
    }
}
