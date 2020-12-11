import java.util.Scanner;

public class CinemaTickets
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String film = scanner.nextLine();
        int totalsales = 0;
        double student = 0;
        double standart = 0;
        double kids = 0;
        while (!film.equals("Finish"))
        {
            int freeseats = Integer.parseInt(scanner.nextLine());
            String command = scanner.nextLine();
            int saleseats = 0;
            while (!command.equals("End"))
            {

                if (command.equals("student"))
                {
                    student += 1;
                }
                else if (command.equals("standard"))
                {
                    standart += 1;
                }
                else if (command.equals("kid"))
                {
                    kids += 1;
                }
                saleseats += 1;
                totalsales += 1;
                if (saleseats == freeseats)
                {
                    break;
                }
                command = scanner.nextLine();
            }
            double percent = 1.0 * saleseats / freeseats * 100;
            System.out.printf("%s - %.2f%% full.%n", film, percent);
            film = scanner.nextLine();
        }
        if (film.equals("Finish"))
        {
            double percentstudent = student / totalsales * 100;
            double percentstandart = standart / totalsales * 100;
            double percentkids = kids / totalsales * 100;
            System.out.printf("Total tickets: %d%n", totalsales);
            System.out.printf("%.2f%% student tickets.%n", percentstudent);
            System.out.printf("%.2f%% standard tickets.%n", percentstandart);
            System.out.printf("%.2f%% kids tickets.%n", percentkids);

        }
    }
}

