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
        Dictionary<string, int> oddTimes = new Dictionary<string, int>();
        foreach (var item in input)
        {
            string tolowerCase = item.ToLower();
            if (oddTimes.ContainsKey(tolowerCase))
            {
                oddTimes[tolowerCase] += 1;
            }
            else
            {
                oddTimes.Add(tolowerCase, 1);
            }
        }
        foreach (var item in oddTimes)
        {
            if (item.Value % 2 != 0)
            {
                Console.Write(item.Key + " ");
            }
        }

    }
}
