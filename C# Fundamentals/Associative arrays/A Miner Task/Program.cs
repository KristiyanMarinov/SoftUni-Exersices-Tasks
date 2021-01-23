using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;

class HolidaysBetweenTwoDates
{
    static void Main()
    {

        Dictionary<string, int> resourses = new Dictionary<string, int>();
        string input = Console.ReadLine();


        while (input != "stop")
        {
            int number = int.Parse(Console.ReadLine());

            if (!resourses.ContainsKey(input))
            {
                resourses.Add(input, number);
            }
            else
            {
                resourses[input] += number;
            }
            input = Console.ReadLine();

        }
        foreach (var item in resourses)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}