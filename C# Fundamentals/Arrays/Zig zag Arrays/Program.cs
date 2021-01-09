using System;
using System.IO.IsolatedStorage;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    firstArray[i] = input[1];
                    secondArray[i] = input[0];
                }
                else
                {
                    secondArray[i] = input[1];
                    firstArray[i] = input[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}

