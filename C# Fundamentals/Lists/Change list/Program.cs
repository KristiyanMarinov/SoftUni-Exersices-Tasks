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

            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "end")
            {
                if (command[0].Equals("Delete"))
                {
                    input.RemoveAll(g => g == int.Parse(command[1]));
                }
                else
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
