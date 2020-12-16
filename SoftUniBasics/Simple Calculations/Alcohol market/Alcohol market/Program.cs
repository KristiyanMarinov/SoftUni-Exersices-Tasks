import java.util.Scanner;

public class AlcoholMarket
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double priceUiski = Double.parseDouble(scanner.nextLine());
        double beerq = Double.parseDouble(scanner.nextLine());
        double vinoq = Double.parseDouble(scanner.nextLine());
        double rakiqq = Double.parseDouble(scanner.nextLine());
        double uiskiq = Double.parseDouble(scanner.nextLine());

        double pricerakiq = priceUiski * 0.5;
        double pricevino = pricerakiq * 0.6;
        double pricebeer = pricerakiq * 0.2;
        System.out.printf("%.2f", priceUiski * uiskiq + beerq * pricebeer + vinoq * pricevino + rakiqq * pricerakiq);
    }

}

