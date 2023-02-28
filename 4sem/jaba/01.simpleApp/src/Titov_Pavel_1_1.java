import java.util.Scanner;
import java.lang.Math;

public class Titov_Pavel_1_1 {
    public static void main(String[] args) throws Exception {
        try (Scanner input = new Scanner(System.in)) {
            // task 1
            System.out.print("a: ");
            double a = input.nextDouble();
            System.out.print("b: ");
            double b = input.nextDouble();

            double average = (a + b) / 2;
            double geometricMean = Math.sqrt(a * b);
            System.out.printf("The average of %.2f and %.2f is %.2f\n", a, b, average);
            System.out.printf("The geometric mean of %.2f and %.2f is %.2f\n", a, b, geometricMean);
        }
    }
}
