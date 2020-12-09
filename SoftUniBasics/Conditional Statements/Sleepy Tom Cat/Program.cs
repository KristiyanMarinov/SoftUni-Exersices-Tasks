import java.util.Scanner;

public class SleepyTomCat
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int restdays = Integer.parseInt(scanner.nextLine());
        int norm = 30000;
        int workdays = 365 - restdays;
        int playtime = workdays * 63 + restdays * 127;
        if (playtime > 30000)
        {
            int moreplaytime = playtime - 30000;
            System.out.println("Tom will run away");
            System.out.printf("%d hours and %d minutes more for play", moreplaytime / 60, moreplaytime % 60);
        }
        else
        {
            int lessplaytime = 30000 - playtime;
            System.out.println("Tom sleeps well");
            System.out.printf("%d hours and %d minutes less for play", lessplaytime / 60, lessplaytime % 60);
        }
    }
}
