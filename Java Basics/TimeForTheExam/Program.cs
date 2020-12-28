import java.util.Scanner;

public class OnTimeFotTheExam
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int hourexam = Integer.parseInt(scanner.nextLine());
        int minuteexam = Integer.parseInt(scanner.nextLine());
        int hourarrive = Integer.parseInt(scanner.nextLine());
        int minutearrive = Integer.parseInt(scanner.nextLine());
        int examinminute = hourexam * 60 + minuteexam;
        int arriveinminute = hourarrive * 60 + minutearrive;
        if (arriveinminute > examinminute)
        {
            if (arriveinminute < examinminute + 60)
            {
                System.out.printf("Late %d minutes after the start", arriveinminute - examinminute);
            }
            else
            {
                System.out.printf("Late %d:%02d hours after the start", hourarrive - hourexam, Math.abs(minutearrive - minuteexam));
            }

        }
        else if (arriveinminute <= examinminute)
        {
            if (arriveinminute == examinminute)
            {
                System.out.println("On time");
            }
            else if (arriveinminute >= examinminute - 30)
            {
                System.out.printf("On time %d minutes before the start", examinminute - arriveinminute);
            }
            else if (arriveinminute < examinminute - 30 && arriveinminute > examinminute - 60)
            {
                System.out.printf("Early %d minutes before the start", examinminute - arriveinminute);
            }
            else
            {
                int d = (examinminute - arriveinminute) / 60;
                int f = (examinminute - arriveinminute) % 60;
                System.out.printf("Early %d:%02d hours before the start", d, f);
            }

        }

    }

}
