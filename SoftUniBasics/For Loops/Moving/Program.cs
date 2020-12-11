import java.util.Scanner;

public class Moving
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int w = Integer.parseInt(scanner.nextLine());
        int l = Integer.parseInt(scanner.nextLine());
        int h = Integer.parseInt(scanner.nextLine());
        int room = w * l * h;
        String order = scanner.nextLine();
        int packs = 0;
        while (!order.equals("Done"))
        {
            packs += Integer.parseInt(order);

            if (room <= packs)
            {
                int needroom = packs - room;
                System.out.printf("No more free space! You need %d Cubic meters more.", needroom);
                break;
            }
            order = scanner.nextLine();
        }
        if (room > packs)
        {
            int freeroom = room - packs;
            System.out.printf("%d Cubic meters left.", freeroom);
        }
    }

}
