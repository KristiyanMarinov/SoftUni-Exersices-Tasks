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
            int capacity = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "end")
            {
                if (command.Length > 1)
                {
                    input.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if ((input[i] + int.Parse(command[0])) <= capacity)
                        {
                            input[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
