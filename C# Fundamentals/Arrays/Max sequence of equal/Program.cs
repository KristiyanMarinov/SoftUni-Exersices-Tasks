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
            int theBest = 1;
            int curr = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int theLongest = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (input[i] == input[j])
                    {
                        theLongest += 1;
                        if (theLongest >= theBest)
                        {
                            theBest = theLongest;
                            curr = input[j];
                        }

                    }
                    else
                    {
                        break;
                    }
                }

            }
            for (int i = 1; i <= theBest; i++)
            {
                Console.Write(curr + " ");
            }
        }
    }
}

