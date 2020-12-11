import java.util.Scanner;

public class ExellentResult
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double ocenka = Double.parseDouble(scanner.nextLine());
        if (ocenka >= 5.5)
        {
            System.out.println("Excellent!");
        }
    }
}

