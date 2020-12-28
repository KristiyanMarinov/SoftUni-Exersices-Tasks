import java.util.Scanner;

public class SumOfTwoNumbers
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int start = Integer.parseInt(scanner.nextLine());
        int end = Integer.parseInt(scanner.nextLine());
        int magic = Integer.parseInt(scanner.nextLine());
        int sum = 0;
        boolean sbor = false;
        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                sum += 1;
                if (i + j == magic)
                {
                    System.out.printf("Combination N:%d (%d + %d = %d)", sum, i, j, i + j);
                    sbor = true;
                    break;
                }
                if (i == end && j == end)
                {
                    System.out.printf("%d combinations - neither equals %d", sum, magic);
                }
            }
            if (sbor)
            {
                break;
            }
        }
    }
}





