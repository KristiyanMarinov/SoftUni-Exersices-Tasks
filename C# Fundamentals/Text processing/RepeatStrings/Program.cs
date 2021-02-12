using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class HolidaysBetweenTwoDates
{
    static void Main()

    {
        string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string newWord = "";
        for (int i = 0; i < command.Length; i++)
        {
            for (int j = 0; j < command[i].Length; j++)
            {
                newWord += command[i];
            }
        }
        Console.WriteLine(newWord);
    }
}