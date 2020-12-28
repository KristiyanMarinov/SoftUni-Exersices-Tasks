import java.util.Scanner;

public class Histogram
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;

        for (int i = 1; i <= n; i++)
        {
            int number = Integer.parseInt(scanner.nextLine());
            if (number < 200)
            {
                p1 += 1;
            }
            else if (number >= 200 && number < 400)
            {
                p2 += 1;
            }
            else if (number >= 400 && number < 600)
            {
                p3 += 1;
            }
            else if (number >= 600 && number < 800)
            {
                p4 += 1;
            }
            else
            {
                p5 += 1;
            }
        }
        int all = p1 + p2 + p3 + p4 + p5;
        double percentp1 = 1.0 * 100 * p1 / all;
        double percentp2 = 1.0 * 100 * p2 / all;
        double percentp3 = 1.0 * 100 * p3 / all;
        double percentp4 = 1.0 * 100 * p4 / all;
        double percentp5 = 1.0 * 100 * p5 / all;
        System.out.printf("%.2f%%", percentp1);
        System.out.printf("%.2f%%", percentp2);
        System.out.printf("%.2f%%", percentp3);
        System.out.printf("%.2f%%", percentp4);
        System.out.printf("%.2f%%", percentp5);
    }
}
