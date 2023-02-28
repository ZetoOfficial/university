import java.util.Scanner;
import java.lang.Math;

public class Titov_Pavel_2_1 {
    public static void main(String[] args) throws Exception {
        try (Scanner input = new Scanner(System.in)) {
            // task 1
            System.out.print("a: ");
            double a = input.nextDouble();
            System.out.print("b: ");
            double b = input.nextDouble();
            System.out.print("c: ");
            double c = input.nextDouble();

            System.out.print("x: ");
            double x = input.nextDouble();
            double answer;

            if (x == 0 && b != 0) {
                answer = a * Math.pow(x + c, 2) - b;
            } else if (x == 0 && b == 0) {
                answer = (x - a) / -c;
            } else {
                answer = a + x / b;
            }

            System.out.printf("Answer: %.2f\n", answer);
        }
    }
}
