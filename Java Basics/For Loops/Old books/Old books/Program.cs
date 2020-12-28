import java.util.Scanner;

public class OldBook
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String book = scanner.nextLine();
        int capacity = Integer.parseInt(scanner.nextLine());
        String floor = scanner.nextLine();
        int count = 0;
        while (!floor.equals(book))
        {
            count += 1;

            if (count >= capacity)
            {
                System.out.println("The book you search is not here!");
                System.out.printf("You checked %d books.", count);
                break;
            }
            floor = scanner.nextLine();
        }
        if (floor.equals(book))
            System.out.printf("You checked %d books and found it.", count);
    }
}

