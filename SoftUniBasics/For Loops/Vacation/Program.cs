import java.util.Scanner;

public class Vacation
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double needmoney = Double.parseDouble(scanner.nextLine());
        double ownedmoney = Double.parseDouble(scanner.nextLine());
        int daysspend = 0;
        int daycount = 0;

        while (ownedmoney < needmoney)
        {
            String act = scanner.nextLine();
            double newmoney = Double.parseDouble(scanner.nextLine());
            if (act.equals("spend"))
            {
                daysspend += 1;
                ownedmoney -= newmoney;
                if (ownedmoney < 0)
                {
                    ownedmoney = 0;
                }
            }
            else if (act.equals("save"))
            {
                ownedmoney += newmoney;
                daysspend = 0;

            }
            daycount += 1;
            if (daysspend == 5)
            {
                System.out.println("You can't save the money.");
                System.out.println(daycount);
                break;
            }

        }
        if (ownedmoney >= needmoney)
        {
            System.out.printf("You saved the money for %d days.", daycount);
        }
    }
}

