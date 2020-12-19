import java.util.Scanner;

public class ExamPreparation
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int badmarks = Integer.parseInt(scanner.nextLine());
        int numberbadmarks = 0;
        int numbermarks = 0;
        double summarks = 0;
        String lastproblem = "";
        boolean isFailed = true;

        while (numberbadmarks < badmarks)
        {
            String namemark = scanner.nextLine();
            if (namemark.equals("Enough"))
            {
                isFailed = false;
                break;
            }
            int mark = Integer.parseInt(scanner.nextLine());
            if (mark <= 4)
            {
                numberbadmarks++;
            }
            summarks += mark;
            numbermarks += 1;
            lastproblem = namemark;
        }
        if (isFailed)
        {
            System.out.printf("You need a break, %d poor grades.", numberbadmarks);
        }
        else
        {
            System.out.printf("Average score: %.2f%n", summarks / numbermarks);
            System.out.printf("Number of problems: %d%n", numbermarks);
            System.out.printf("Last problem: %s", lastproblem);
        }

    }
}

