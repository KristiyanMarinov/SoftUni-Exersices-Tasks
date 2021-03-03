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
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int n = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    result.Append(input[i]);
                    n += 1;
                }

            }
            if (n > 0)
            {

                if (input[input.Length - 1] != result[result.Length - 1])
                {
                    result.Append(input[input.Length - 1]);
                }
            }
            else
            {
                result.Append(input[0]);
            }

            Console.WriteLine(result);
        }
    }
}
