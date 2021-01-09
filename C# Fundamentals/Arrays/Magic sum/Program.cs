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
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                int curr = input[i];
                for (int j = i + 1; j < input.Length; j++)
                {
                    if ((curr + input[j]) == number)
                    {
                        Console.Write(curr + " " + input[j]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

