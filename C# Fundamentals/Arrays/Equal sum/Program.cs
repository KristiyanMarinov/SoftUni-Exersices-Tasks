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
            bool isFound = false;

            for (int curr = 0; curr < input.Length; curr++)
            {
                int sumRight = 0;
                for (int i = curr + 1; i < input.Length; i++)
                {
                    sumRight += input[i];
                }
                int sumLeft = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    sumLeft += input[i];
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(curr);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }


        }
    }
}

