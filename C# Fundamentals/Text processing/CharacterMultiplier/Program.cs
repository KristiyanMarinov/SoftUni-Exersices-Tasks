using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class HolidaysBetweenTwoDates
{
    static void Main(string[] args)

    {
        string[] input = Console.ReadLine().Split(" ");

        int result = 0;
        int smallerInt = Math.Min(input[0].Length, input[1].Length);

        for (int i = 0; i < smallerInt; i++)
        {
            result += input[0][i] * input[1][i];
        }
        if (input[0].Length > input[1].Length)
        {
            int difference = input[0].Length - input[1].Length;
            for (int i = input[0].Length - difference; i < input[0].Length; i++)
            {
                result += input[0][i];
            }
        }
        else if (input[0].Length < input[1].Length)
        {
            int difference = input[1].Length - input[0].Length;
            for (int i = input[1].Length - difference; i < input[1].Length; i++)
            {
                result += input[1][i];
            }
        }
        Console.WriteLine(result);
    }
}