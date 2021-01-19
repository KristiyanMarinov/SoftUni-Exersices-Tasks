using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;

class HolidaysBetweenTwoDates
{
    static void Main()
    {

        string[] input = Console.ReadLine().Split();
        input.Where(x => x.Length % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));

    }
}