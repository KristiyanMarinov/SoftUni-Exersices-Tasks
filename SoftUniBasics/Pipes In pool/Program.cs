import java.util.Scanner;

public class PipesinPool
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int V = Integer.parseInt(scanner.nextLine());
        int p1 = Integer.parseInt(scanner.nextLine());
        int p2 = Integer.parseInt(scanner.nextLine());
        double H = Double.parseDouble(scanner.nextLine());
        double V1 = Math.floor((p1 + p2) * H / V * 100);
        if (V1 > 100)
        {
            double overflows = ((p1 + p2) * H) - V;
            System.out.printf("For %.2f hours the pool overflows with %.2f liters.", H, overflows);
        }
        else
        {

            double litersfrompipes = (p1 + p2);
            double p1inpercent = Math.floor((p1 / litersfrompipes) * 100);
            double p2inpercent = Math.floor((p2 / litersfrompipes) * 100);
            System.out.printf("The pool is %.0f%% full. Pipe 1: %.0f%%. Pipe 2: %.0f%%.", V1, p1inpercent, p2inpercent);
        }
    }
}
