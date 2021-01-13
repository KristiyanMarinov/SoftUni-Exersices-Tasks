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
            string[] comand = Console.ReadLine().Split(" ");
            int curr = 0;

            while (!comand[0].Equals("end"))
            {
                switch (comand[0])
                {
                    case "Add":
                        input.Add(int.Parse(comand[1]));
                        curr += 1;
                        break;
                    case "Remove":
                        input.Remove(int.Parse(comand[1]));
                        curr += 1;
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(comand[1]));
                        curr += 1;
                        break;
                    case "Insert":
                        input.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                        curr += 1;
                        break;
                    case "Contains":
                        if (input.Contains(int.Parse(comand[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;

                    case "PrintEven":
                        List<int> even = new List<int>();
                        foreach (int item in input)
                        {
                            if (item % 2 == 0)
                            {
                                even.Add(item);
                            }
                        }
                        Console.WriteLine(string.Join(" ", even));
                        break;

                    case "PrintOdd":
                        List<int> odd = new List<int>();
                        foreach (int item in input)
                        {
                            if (item % 2 != 0)
                            {
                                odd.Add(item);
                            }
                        }
                        Console.WriteLine(string.Join(" ", odd));
                        break;

                    case "GetSum":
                        int sum = 0;
                        foreach (int item in input)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        if (comand[1] == ">")
                        {
                            List<int> bigger = new List<int>();
                            foreach (int item in input)
                            {
                                if (item > int.Parse(comand[2]))
                                {
                                    bigger.Add(item);
                                }
                            }
                            Console.WriteLine(string.Join(" ", bigger));
                        }
                        else if (comand[1] == ">=")
                        {
                            List<int> biggerOrEqual = new List<int>();
                            foreach (int item in input)
                            {
                                if (item >= int.Parse(comand[2]))
                                {
                                    biggerOrEqual.Add(item);
                                }
                            }
                            Console.WriteLine(string.Join(" ", biggerOrEqual));
                        }
                        else if (true)
                        {
                            List<int> smallerOrEqual = new List<int>();
                            foreach (int item in input)
                            {
                                if (item <= int.Parse(comand[2]))
                                {
                                    smallerOrEqual.Add(item);
                                }
                            }
                            Console.WriteLine(string.Join(" ", smallerOrEqual));
                        }
                        break;

                }
                comand = Console.ReadLine().Split(" ");
            }
            if (curr > 0)
            {
                Console.WriteLine(string.Join(" ", input));
            }

        }
    }
}
