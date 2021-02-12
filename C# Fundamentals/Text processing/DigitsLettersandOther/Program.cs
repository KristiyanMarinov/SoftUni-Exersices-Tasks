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
        char[] input = Console.ReadLine().ToCharArray();
        string digits = string.Empty;
        string letters = string.Empty;
        string symbols = string.Empty;

        foreach (var item in input)
        {
            if (char.IsDigit(item))
            {
                digits += item;
            }
            else if (char.IsLetter(item))
            {
                letters += item;
            }
            else
            {
                symbols += item;
            }

        }
        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(symbols);



    }
}