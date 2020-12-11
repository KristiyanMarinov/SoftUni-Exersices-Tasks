import java.util.Scanner;

public class SmallShop
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String product = scanner.nextLine();
        String town = scanner.nextLine();
        double broi = Double.parseDouble(scanner.nextLine());
        if ("Sofia".equals(town))
        {
            if ("coffee".equals(product))
            {
                System.out.println(0.5 * broi);
            }
            else if ("water".equals(product))
            {
                System.out.println(0.8 * broi);
            }
            else if ("beer".equals(product))
            {
                System.out.println(1.2 * broi);
            }
            else if ("sweets".equals(product))
            {
                System.out.println(1.45 * broi);
            }
            else if ("peanuts".equals(product))
            {
                System.out.println(1.6 * broi);
            }
        }
        if ("Plovdiv".equals(town))
        {
            if ("coffee".equals(product))
            {
                System.out.println(0.4 * broi);
            }
            else if ("water".equals(product))
            {
                System.out.println(0.7 * broi);
            }
            else if ("beer".equals(product))
            {
                System.out.println(1.15 * broi);
            }
            else if ("sweets".equals(product))
            {
                System.out.println(1.30 * broi);
            }
            else if ("peanuts".equals(product))
            {
                System.out.println(1.5 * broi);
            }
        }
        if ("Varna".equals(town))
        {
            if ("coffee".equals(product))
            {
                System.out.println(0.45 * broi);
            }
            else if ("water".equals(product))
            {
                System.out.println(0.7 * broi);
            }
            else if ("beer".equals(product))
            {
                System.out.println(1.1 * broi);
            }
            else if ("sweets".equals(product))
            {
                System.out.println(1.35 * broi);
            }
            else if ("peanuts".equals(product))
            {
                System.out.println(1.55 * broi);
            }
        }
    }
}
