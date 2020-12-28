import java.util.Scanner;

public class OddevenPosition
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        double sumeven = 0;
        double sumodd = 0;
        double maxeven = Integer.MIN_VALUE;
        double mineven = Integer.MAX_VALUE;
        double maxodd = Integer.MIN_VALUE;
        double minodd = Integer.MAX_VALUE;
        for (int i = 1; i <= n; i++)
        {
            double number = Double.parseDouble(scanner.nextLine());
            if (i % 2 == 0)
            {
                sumeven += number;
                if (number > maxeven)
                {
                    maxeven = number;
                }
                if (number < mineven)
                {
                    mineven = number;
                }

            }
            else if (i % 2 != 0)
            {
                sumodd += number;
                if (number > maxodd)
                {
                    maxodd = number;
                }
                if (number < minodd)
                {
                    minodd = number;
                }
            }
        }
        System.out.printf("OddSum=%.2f,%n", sumodd);
        if (n == 0)
        {
            System.out.printf("OddMin=No,%n");
            System.out.printf("OddMax=No,%n");
        }
        else
        {
            System.out.printf("OddMin=%.2f,%n", minodd);
            System.out.printf("OddMax=%.2f,%n", maxodd);
        }
        System.out.printf("EvenSum=%.2f,%n", sumeven);
        if (n < 2)
        {
            System.out.printf("EvenMin=No,%n");
            System.out.printf("EvenMax=No");
        }
        else
        {
            System.out.printf("EvenMin=%.2f,%n", mineven);
            System.out.printf("EvenMax=%.2f", maxeven);
        }

    }

}

