import java.util.Scanner;

public class Harvest
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int X = Integer.parseInt(scanner.nextLine());
        double forvine = 0.4 * X;
        double Y = Double.parseDouble(scanner.nextLine());
        double kg = forvine * Y;
        double liters = kg / 2.5;
        int Z = Integer.parseInt(scanner.nextLine());
        int workers = Integer.parseInt(scanner.nextLine());
        if (liters < Z)
        {
            System.out.printf("It will be a tough winter! More %.0f liters wine needed.", Math.floor(Z - liters));
        }
        else
        {
            System.out.printf("Good harvest this year! Total wine: %.0f liters.%n", Math.floor(liters));
            System.out.printf("%.0f liters left -> %.0f liters per person.", Math.ceil(liters - Z), Math.ceil((liters - Z) / workers));
        }
    }
}

