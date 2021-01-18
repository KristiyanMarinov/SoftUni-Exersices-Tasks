using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = new List<string>();

            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(" ");
                if (command.Length < 4)
                {
                    if (input.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        input.Add(command[0]);
                    }
                }
                else
                {
                    if (input.Contains(command[0]))
                    {
                        input.Remove(command[0]);
                    }
                    else
                    {

                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
