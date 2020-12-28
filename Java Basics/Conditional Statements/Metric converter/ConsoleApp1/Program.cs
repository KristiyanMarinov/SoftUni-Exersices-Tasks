import java.util.Scanner;

public class MetricConverter
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double number = Double.parseDouble(scanner.nextLine());
        String medinica = scanner.nextLine();
        String exitedinica = scanner.nextLine();
        double exitnumber = 0;
        double mm = number * 1000;
        double cm = number * 100;

        if (medinica.equals("m"))
        {
            number = 1 * number;
        }
        else if (medinica.equals("cm"))
        {
            number = 0.01 * number;
        }
        else if (medinica.equals("mm"))
        {
            number = 0.001 * number;

        }
        if (exitedinica.equals("m"))
        {

            System.out.printf("%.3f", number * 1);
        }
        else if (exitedinica.equals("cm"))
        {

            System.out.printf("%.3f", number * 100);
        }
        else if (exitedinica.equals("mm"))
        {

            System.out.printf("%.3f", number * 1000);
        }


    }
}

