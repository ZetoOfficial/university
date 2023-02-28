import java.util.Scanner;
import java.lang.Math;

public class Titov_Pavel_1_3 {
    public static void main(String[] args) throws Exception {
        try (Scanner input = new Scanner(System.in)) {
            System.out.print("x: ");
            double x = input.nextDouble();
            double y = x * x - Math.sin(x) + Math.cos(x);
            System.out.printf("%.0f^2-sin(%.0f)+cos(%.0f) = %.2f\n", x, x, x, y);
        }
    }
}
