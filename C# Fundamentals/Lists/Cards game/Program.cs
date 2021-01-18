using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (input1.Count != 0 && input2.Count != 0)
            {
                int cur1 = input1[0];
                int cur2 = input2[0];

                if (cur1 > cur2)
                {
                    input1.Add(cur1);
                    input1.Add(cur2);

                }
                else if (cur2 > cur1)
                {
                    input2.Add(cur1);
                    input2.Add(cur2);


                }

                input1.RemoveAt(0);
                input2.RemoveAt(0);


            }
            if (input2.Count == 0)
            {
                int sum = input1.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = input2.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
