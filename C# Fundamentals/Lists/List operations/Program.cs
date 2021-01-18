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
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandNew = command.Split(" ");
                switch (commandNew[0])
                {
                    case "Add":
                        input.Add(int.Parse(commandNew[1]));
                        break;
                    case "Insert":

                        int index = int.Parse(commandNew[2]);
                        if (IsValid(index, input.Count))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            input.Insert(int.Parse(commandNew[2]), int.Parse(commandNew[1]));
                        }
                        break;

                    case "Remove":
                        int index2 = int.Parse(commandNew[1]);
                        if (IsValid(index2, input.Count))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            input.RemoveAt(int.Parse(commandNew[1]));
                        }
                        break;

                    case "Shift":
                        if (commandNew[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(commandNew[2]); i++)
                            {
                                int first = input[0];
                                for (int j = 0; j < input.Count - 1; j++)
                                {
                                    input[j] = input[j + 1];
                                }
                                input[input.Count - 1] = first;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(commandNew[2]); i++)
                            {
                                int last = input[input.Count - 1];
                                for (int j = input.Count - 1; j > 0; j--)
                                {
                                    input[j] = input[j - 1];
                                }
                                input[0] = last;
                            }
                        }
                        break;


                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }

        private static bool IsValid(int index, int count)
        {
            return index < 0 || index >= count;
        }
    }
}
