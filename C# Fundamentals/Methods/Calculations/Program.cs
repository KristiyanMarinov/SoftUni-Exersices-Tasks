using System;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            switch (action)
            {
                case "add":
                    Add(n1, n2);
                    break;
                case "multiply":
                    Multiply(n1, n2);
                    break;
                case "substract":
                    Subtract(n1, n2);
                    break;
                case "divide":
                    Divide(n1, n2);
                    break;

            }


            static void Subtract(int number1, int number2)
            {
                Console.WriteLine(number1 - number2);
            }

            static void Divide(int number1, int number2)
            {
                Console.WriteLine(number1 / number2);
            }

            static void Multiply(int number1, int number2)
            {
                Console.WriteLine(number1 * number2);
            }

            static void Add(int number1, int number2)
            {
                Console.WriteLine(number1 + number2);
            }

        }
    }
}

