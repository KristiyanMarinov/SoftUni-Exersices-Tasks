
import java.util.Scanner;

public class CleverLyli
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int age = Integer.parseInt(scanner.nextLine());
        double wmachine = Double.parseDouble(scanner.nextLine());
        int toyprice = Integer.parseInt(scanner.nextLine());
        int sum = 0;
        int toycount = 0;

        for (int godini = 1; godini <= age; godini++)
        {

            if (godini % 2 == 0)
            {
                sum = sum + (godini * 10) / 2 - 1;
            }
            else if (godini % 2 != 0)
            {
                toycount += 1;
            }
        }
        int saved = sum + (toycount * toyprice);
        double ostanali = saved - wmachine;
        double nestigat = Math.abs(wmachine - saved);
        if (saved >= wmachine)
        {
            System.out.printf("Yes! %.2f", ostanali);
        }
        else
        {
            System.out.printf("No! %.2f", nestigat);
        }
    }
}


