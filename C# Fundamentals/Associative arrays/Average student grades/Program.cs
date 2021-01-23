using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count_same_values_in_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < input; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                decimal grade = decimal.Parse(tokens[1]);
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                }
                students[name].Add(grade);
            }
            foreach (var item in students)
            {
                StringBuilder grades = new StringBuilder();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    
                    grades.Append($"{item.Value[i]:f2} ");
                }
                Console.WriteLine($"{item.Key:f2} -> {grades.ToString()}(avg: {item.Value.Average():f2})");
            }
        }
    }
}
