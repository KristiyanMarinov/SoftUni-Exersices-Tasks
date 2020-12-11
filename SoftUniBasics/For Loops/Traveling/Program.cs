import java.util.Scanner;

public class Travveling
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        while (!input.equals("End"))
        {
            double budget = Double.parseDouble(scanner.nextLine());
            double savedmoney = 0;
            while (savedmoney < budget)
            {
                double newmoney = Double.parseDouble(scanner.nextLine()); ;
                savedmoney += newmoney;
            }
            if (savedmoney >= budget)
            {
                System.out.printf("Going to %s!%n", input);
            }
            input = scanner.nextLine();
        }

    }
}



