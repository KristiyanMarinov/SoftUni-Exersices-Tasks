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
        string command = Console.ReadLine();

        while (command != "end")
        {
            string newWord = "";
            for (int i = command.Length - 1; i >= 0; i--)
            {
                newWord += command[i];
            }
            Console.WriteLine($"{command} = {newWord}");
            command = Console.ReadLine();
        }

    }
}