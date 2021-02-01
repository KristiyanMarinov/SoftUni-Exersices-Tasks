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

        Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, int> usersAllPoints = new Dictionary<string, int>();

        while (command != "no more time")
        {
            string[] commandSplit = command.Split(" -> ");

            string contest = commandSplit[1];
            string userName = commandSplit[0];
            int points = int.Parse(commandSplit[2]);

            if (!submissions.ContainsKey(contest))
            {
                submissions.Add(contest, new Dictionary<string, int>());
                submissions[contest].Add(userName, points);
            }
            else
            {
                if (submissions[contest].ContainsKey(userName))
                {
                    if (submissions[contest][userName] < points)
                    {
                        submissions[contest][userName] = points;
                    }
                }
                else
                {
                    submissions[contest].Add(userName, points);
                }
            }
            command = Console.ReadLine();
        }
        foreach (var contest in submissions)
        {
            foreach (var user in contest.Value)
            {
                if (!usersAllPoints.ContainsKey(user.Key))
                {
                    usersAllPoints.Add(user.Key, user.Value);
                }
                else
                {
                    usersAllPoints[user.Key] += user.Value;
                }
            }
        }
        foreach (var item in submissions)
        {
            Console.WriteLine($"{item.Key}: {item.Value.Count} participants");

            int count = 1;
            foreach (var user in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {user.Key} <::> {user.Value}");
                count += 1;
            }
        }
        Console.WriteLine("Individual standings:");
        int secondcount = 1;
        foreach (var item in usersAllPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{secondcount}. {item.Key} -> {item.Value}");
            secondcount += 1;
        }

    }
}