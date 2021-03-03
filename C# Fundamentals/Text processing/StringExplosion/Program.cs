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
            StringBuilder result = new StringBuilder(input);
            int currBombPower = 0;
            int lastIndex = input.LastIndexOf('>');
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] == '>')
                {
                    currBombPower += int.Parse((result[i + 1]).ToString());
                    continue;
                }
                if (currBombPower > 0)
                {
                    result.Remove(i, 1);
                    i--;
                    currBombPower--;
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}

