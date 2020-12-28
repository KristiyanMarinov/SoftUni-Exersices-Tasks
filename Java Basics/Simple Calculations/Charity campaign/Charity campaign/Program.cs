import java.util.Scanner;

public class CharityCampaign
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int days = Integer.parseInt(scanner.nextLine());
        int sladkari = Integer.parseInt(scanner.nextLine());
        int torti = Integer.parseInt(scanner.nextLine());
        int gofreti = Integer.parseInt(scanner.nextLine());
        int palachinki = Integer.parseInt(scanner.nextLine());
        double pricetorta = 45;
        double pricegofreta = 5.8;
        double pricepalachinka = 3.2;
        double all1gotvach = days * (45 * torti + 5.8 * gofreti + 3.2 * palachinki);
        double allgotvachi = all1gotvach * sladkari;
        double razhodi = allgotvachi * 0.125;
        System.out.printf("%.2f", allgotvachi - razhodi);


    }
}

