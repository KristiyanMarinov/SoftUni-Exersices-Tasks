import java.util.Scanner;

public class YardGreening
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double area = Double.parseDouble(scanner.nextLine());
        double price = area * 7.61;
        double discount = 0.18 * price;
        double endprice = price - discount;
        System.out.print("The final price is: ");
        System.out.printf("%.2f", endprice);
        System.out.println(" lv.");

        System.out.printf("The discount is: %.2f lv.", discount);



    }
}
