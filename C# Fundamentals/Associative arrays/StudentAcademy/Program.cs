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
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string studentName = Console.ReadLine();
            double studentGrade = double.Parse(Console.ReadLine());

            if (!grades.ContainsKey(studentName))
            {
                grades.Add(studentName, new List<double> { studentGrade });
            }
            else
            {
                grades[studentName].Add(studentGrade);
            }
        }
        List<double> average = new List<double>();
        //Dictionary<string,List<double>> filteredDictionary = grades.Where(x => x.Value.Average()>=4.5).Select(x.Value.Average()).ToDictionary(x=>x.Key,y=>y.Value);
        foreach (var item in grades.OrderByDescending(x => x.Value.Average()))
        {
            if (item.Value.Average() >= 4.5)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}