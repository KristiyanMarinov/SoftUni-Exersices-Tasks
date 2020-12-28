import java.util.Scanner;

public class GodzillavsKong
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double budget = Double.parseDouble(scanner.nextLine());
        int statisti = Integer.parseInt(scanner.nextLine());
        double price = Double.parseDouble(scanner.nextLine());
        double price_oblekla = statisti * price;
        double pricedekor = budget * 0.1;
        if (statisti > 150)
        {
            price_oblekla = price_oblekla * 0.9;
        }
        double allprice = price_oblekla + pricedekor;
        if (allprice > budget)
        {
            double miss = allprice - budget;
            System.out.println("Not enough money!");
            System.out.printf("Wingard needs %.2f leva more.", miss);
        }
        else
        {
            double resto = budget - allprice;
            System.out.println("Action!");
            System.out.printf("Wingard starts filming with %.2f leva left.", resto);
        }

    }
}


