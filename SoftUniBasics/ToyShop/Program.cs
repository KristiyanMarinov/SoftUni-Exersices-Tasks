import java.util.Scanner;

public class ToyShop
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double price_eks = Double.parseDouble(scanner.nextLine());
        double pyzeli = Double.parseDouble(scanner.nextLine());
        double kukli = Double.parseDouble(scanner.nextLine());
        double mecheta = Double.parseDouble(scanner.nextLine());
        double minioni = Double.parseDouble(scanner.nextLine());
        double kamioni = Double.parseDouble(scanner.nextLine());

        double broi_igrachki = pyzeli + kukli + mecheta + minioni + kamioni;
        double pricepyzel = pyzeli * 2.6;
        double pricekukli = kukli * 3;
        double pricemecheta = mecheta * 4.1;
        double priceminioni = minioni * 8.2;
        double pricekamioni = kamioni * 2;
        double allcount = pricepyzel + pricekukli + pricemecheta + priceminioni + pricekamioni;
        if (broi_igrachki >= 50)
        {
            allcount = allcount - 0.25 * allcount;

        }
        double rent = 0.1 * allcount;
        double pechalba = allcount - rent;

        if (pechalba >= price_eks)
        {
            double rest = pechalba - price_eks;

            System.out.printf("Yes! %.2f lv left.", rest);
        }
        else
        {
            double lipsa = price_eks - pechalba;
            System.out.printf("Not enough money! %.2f lv needed. ", lipsa);
        }
    }
}
