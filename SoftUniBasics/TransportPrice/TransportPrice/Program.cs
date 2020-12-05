import java.util.Scanner;

public class PriceOfTransport
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        String time = scanner.nextLine();
        double price = 0;
        if (n >= 20 && n < 100)
        {
            price = n * 0.09;
        }
        else if (n >= 100)
        {
            price = 0.06 * n;
        }
        else
        {
            if (time.equals("day"))
            {
                price = 0.7 + 0.79 * n;
            }
            else if (time.equals("night"))
            {
                price = 0.7 + 0.9 * n;
            }
        }
        System.out.printf("%.2f", price);
    }
}

