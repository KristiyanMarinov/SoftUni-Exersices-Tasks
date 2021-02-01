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

        SortedDictionary<string, int> examResults = new SortedDictionary<string, int>();
        SortedDictionary<string, int> submissions = new SortedDictionary<string, int>();
        while (command != "exam finished")
        {
            string[] input = command.Split("-");

            if (input[1] == "banned")
            {
                examResults.Remove(input[0]);

            }
            else
            {
                string username = input[0];
                string language = input[1];
                int points = int.Parse(input[2]);

                if (!examResults.ContainsKey(username))
                {
                    examResults.Add(username, points);
                }
                else
                {
                    if (points > examResults[username])
                    {
                        examResults[username] = points;
                    }
                }

                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 1);
                }
                else
                {
                    submissions[language] += 1;
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine("Results:");
        foreach (var item in examResults.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} | {item.Value}");
        }
        Console.WriteLine("Submissions:");

        foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}