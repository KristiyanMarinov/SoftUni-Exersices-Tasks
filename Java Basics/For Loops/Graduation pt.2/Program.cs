import java.util.Scanner;

public class Graduation_2
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        double summark = 0;
        int i = 1;
        int m = 0;
        while (i <= 12)
        {
            double mark = Double.parseDouble(scanner.nextLine());
            if (mark >= 4)
            {
                summark += mark;
                i++;
            }

            else if (mark < 4)
            {
                m += 1;
                if (m > 1)
                {
                    System.out.printf("%s has been excluded at %d grade", name, i);
                    break;
                }
            }

        }
        if (m <= 1)
        {

            double average = summark / 12;
            System.out.printf("%s graduated. Average grade: %.2f", name, average);
        }
    }

}
