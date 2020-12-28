import java.util.Scanner;

public class SpecilaNumbers
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int N = Integer.parseInt(scanner.nextLine());
        for (int i = 1111; i <= 9999; i++)
        {
            String currentnumber = i + "";
            int sum = 0;
            for (int j = 0; j < currentnumber.length(); j++)
            {
                char currentsymbol = currentnumber.charAt(j);
                int currentedinica = Integer.parseInt(currentsymbol + "");
                if (currentedinica != 0)
                {
                    if ((N % currentedinica) == 0)
                    {
                        sum += 1;
                    }
                }

            }
            if (sum == 4)
            {
                System.out.print(i + " ");
            }
        }
    }
}

