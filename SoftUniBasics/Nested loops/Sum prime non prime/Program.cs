import java.util.Scanner;

public class SumprimeNotPrime
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String command = scanner.nextLine();
        int sumprime = 0;
        int sumnonprime = 0;
        while (!command.equals("stop"))
        {
            int number = Integer.parseInt(command);
            if (number < 0)
            {
                System.out.println("Number is negative.");
                command = scanner.nextLine();
                continue;
            }
            boolean nonprime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    sumnonprime += number;
                    nonprime = false;
                    break;
                }
            }
            if (nonprime)
            {
                sumprime += number;
            }
            command = scanner.nextLine();
        }
        System.out.printf("Sum of all prime numbers is: %d%n", sumprime);
        System.out.printf("Sum of all non prime numbers is: %d%n", sumnonprime);
    }
}


