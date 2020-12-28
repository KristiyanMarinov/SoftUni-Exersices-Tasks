using System;

namespace Vacation

{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeOfGroupe = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (typeOfGroupe)
            {
                case "Students":
                    if (day.Equals("Friday"))
                    {
                        if (countPeople >= 30)
                        {
                            price = 8.45 * countPeople * 0.85;
                        }
                        else
                        {
                            price = 8.45 * countPeople;
                        }
                    }
                    else if (day.Equals("Saturday"))
                    {

                        if (countPeople >= 30)
                        {
                            price = 9.8 * countPeople * 0.85;
                        }
                        else
                        {
                            price = 9.8 * countPeople;
                        }
                    }
                    else if (day.Equals("Sunday"))
                    {

                        if (countPeople >= 30)
                        {
                            price = 10.46 * countPeople * 0.85;
                        }
                        else
                        {
                            price = 10.46 * countPeople;
                        }
                    }
                    ; break;

                case "Business":
                    if (day.Equals("Friday"))
                    {
                        if (countPeople >= 100)
                        {
                            price = 10.90 * countPeople * 0.9;
                        }
                        else
                        {
                            price = 10.90 * countPeople;
                        }
                    }
                    else if (day.Equals("Saturday"))
                    {

                        if (countPeople >= 100)
                        {
                            price = 15.60 * countPeople * 0.90;
                        }
                        else
                        {
                            price = 15.60 * countPeople;
                        }
                    }
                    else if (day.Equals("Sunday"))
                    {

                        if (countPeople >= 100)
                        {
                            price = 16 * countPeople * 0.9;
                        }
                        else
                        {
                            price = 16 * countPeople;
                        }
                    }
                    ; break;

                case "Regular":
                    if (day.Equals("Friday"))
                    {
                        if (countPeople >= 10 && countPeople <= 20)
                        {
                            price = 15 * countPeople * 0.95;
                        }
                        else
                        {
                            price = 15 * countPeople;
                        }
                    }
                    else if (day.Equals("Saturday"))
                    {

                        if (countPeople >= 10 && countPeople <= 20)
                        {
                            price = 20 * countPeople * 0.95;
                        }
                        else
                        {
                            price = 20 * countPeople;
                        }
                    }
                    else if (day.Equals("Sunday"))
                    {

                        if (countPeople >= 10 && countPeople <= 20)
                        {
                            price = 22.5 * countPeople * 0.95;
                        }
                        else
                        {
                            price = 22.5 * countPeople;
                        }
                    }
                    ; break;
            }
            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}

