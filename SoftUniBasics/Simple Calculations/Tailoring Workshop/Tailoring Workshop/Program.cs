
import java.util.Scanner;

public class TailoringWorkshop
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double tables = Double.parseDouble(scanner.nextLine());
        double lenght = Double.parseDouble(scanner.nextLine());
        double widht = Double.parseDouble(scanner.nextLine());
        double areapokrivka = (lenght + 0.60) * (widht + 0.60);
        double areakareta = (lenght / 2) * (lenght / 2);
        double allareapokrivka = tables * areapokrivka;
        double allareakareta = tables * areakareta;
        double pricedollar = (allareakareta * 9) + (allareapokrivka * 7);
        double pricelev = 1.85 * pricedollar;
        System.out.printf("%.2f", pricedollar);
        System.out.println(" USD");
        System.out.printf("%.2f", pricelev);
        System.out.println(" BGN");

    }
}

