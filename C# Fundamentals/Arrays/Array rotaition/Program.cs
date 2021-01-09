using System;
using System.IO.IsolatedStorage;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int first = input[0];
                for (int j = 0; j <= input.Length - 1; j++)
                {
                    if (j == input.Length - 1)
                    {
                        input[input.Length - 1] = first;
                    }
                    else
                    {

                        input[j] = input[j + 1];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

