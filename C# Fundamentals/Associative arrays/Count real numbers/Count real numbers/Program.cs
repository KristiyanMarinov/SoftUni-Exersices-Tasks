using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        SortedDictionary<double, int> myDictionary = new SortedDictionary<double, int>();

        foreach (var item in numbers)
        {
            if (myDictionary.ContainsKey(item))
            {
                myDictionary[item] += 1;
            }
            else
            {
                myDictionary.Add(item, 1);
            }
        }
        foreach (var item in myDictionary)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}