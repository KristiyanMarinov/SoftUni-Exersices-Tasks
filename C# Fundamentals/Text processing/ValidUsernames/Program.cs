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
        string[] input = Console.ReadLine().Split(", ");

        foreach (var item in input)
        {
            if (item.Length <= 16 && item.Length >= 3)
            {
                bool isTrue = true;
                foreach (var symbol in item)
                {
                    if (!(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_'))
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}