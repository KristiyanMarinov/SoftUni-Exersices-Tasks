using System;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int yeild = int.Parse(Console.ReadLine());
            int days = 0;
            int extract = 0;

            while (yeild >= 100)
            {
                days += 1;
                extract += yeild;




                if (extract >= 26)
                {
                    extract -= 26;
                }
                yeild -= 10;

            }
            if (extract >= 26)
            {
                extract -= 26;
            }


            Console.WriteLine(days);
            Console.WriteLine(extract);

        }
    }
}

