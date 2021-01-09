using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            Console.WriteLine(GetMax(input, n1, n2));

            static string GetMax(string input, string n1, string n2)
            {

                switch (input)
                {
                    case "int":
                        if (int.Parse(n1) > int.Parse(n2))
                        {
                            return n1;
                        }
                        else
                        {
                            return n2;
                        }

                    case "char":
                        if (char.Parse(n1) > char.Parse(n2))
                        {
                            return n1;
                        }
                        else
                        {
                            return n2;
                        }
                    case "string":
                        int compare = n1.CompareTo(n2);
                        if (compare > 0)
                        {
                            return n1;
                        }
                        else
                        {
                            return n2;
                        }
                    default:
                        return "";
                }
            }

        }
    }
}

