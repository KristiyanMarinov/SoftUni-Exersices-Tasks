using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string command = Console.ReadLine();

        SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();
        while (command != "End")
        {
            string[] input = command.Split(" -> ");
            string companyName = input[0];
            string employeeName = input[1];

            if (!companies.ContainsKey(companyName))
            {
                companies.Add(companyName, new List<string> { employeeName });
            }
            else
            {
                if (!companies[companyName].Contains(employeeName))
                {
                    companies[companyName].Add(employeeName);
                }
            }
            command = Console.ReadLine();
        }
        foreach (var item in companies)
        {
            Console.WriteLine(item.Key);
            foreach (var id in item.Value)
            {
                Console.WriteLine($"-- {id}");
            }
        }
    }
}