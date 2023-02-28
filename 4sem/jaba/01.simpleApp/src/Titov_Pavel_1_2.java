import java.util.Scanner;
import java.lang.Math;

public class Titov_Pavel_1_2 {
    public static void main(String[] args) throws Exception {
        try (Scanner input = new Scanner(System.in)) {
            // task 2
            System.out.print("a: ");
            double a = input.nextDouble();
            System.out.print("b: ");
            double b = input.nextDouble();

            double hypotenuse = Math.sqrt(a * a + b * b);
            System.out.printf("The length of the hypotenuse is %.2f\n", hypotenuse);
        }
    }
}
