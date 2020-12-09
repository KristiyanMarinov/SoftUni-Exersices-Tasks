import java.util.Scanner;

public class PetShop
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int dogs = Integer.parseInt(scanner.nextLine());
        int other = Integer.parseInt(scanner.nextLine());
        double razhod = 2.5 * dogs;
        int otherdogs = 4 * other;
        double all = razhod + otherdogs;
        System.out.printf("%.2f", all);
        System.out.println(" lv.");


    }
}

