using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currString = input[i];
                double currNumber = double.Parse(currString.Substring(1, currString.Length - 2));
                if (char.IsUpper(currString[0]))
                {
                    currNumber = currNumber / (currString[0] - 64);
                }
                else
                {
                    currNumber = currNumber * (currString[0] - 96);
                }


                if (char.IsUpper(currString[currString.Length - 1]))
                {
                    currNumber = currNumber - (currString[currString.Length - 1] - 64);
                }
                else
                {
                    currNumber += (currString[currString.Length - 1] - 96);
                }
                result += currNumber;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
