using System;
using System.IO.IsolatedStorage;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(" ");
            string[] secondLine = Console.ReadLine().Split(" ");
            string forPrint = "";
            for (int i = 0; i < secondLine.Length; i++)
            {
                for (int j = 0; j < firstLine.Length; j++)
                {
                    if (secondLine[i].Equals(firstLine[j]))
                    {
                        forPrint += " " + secondLine[i];
                    }
                }
            }
            Console.WriteLine(forPrint);
        }
    }
}

