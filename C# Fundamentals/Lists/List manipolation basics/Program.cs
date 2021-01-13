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

            while (!comand[0].Equals("end"))
            {
                switch (comand[0])
                {
                    case "Add":
                        input.Add(int.Parse(comand[1]));
                        break;
                    case "Remove":
                        input.Remove(int.Parse(comand[1]));
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(comand[1]));
                        break;
                    case "Insert":
                        input.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                        break;
                }
                comand = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

