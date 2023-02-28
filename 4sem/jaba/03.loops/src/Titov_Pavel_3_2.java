import java.util.Scanner;

public class Titov_Pavel_3_2 {
    public static void main(String[] args) throws Exception {
        try (Scanner input = new Scanner(System.in)) {
            System.out.print("eps: ");
            double epsilon = input.nextDouble();

            double sum = 0;
            double term = 1;
            int n = 1;

            while (term >= epsilon) {
                term = 1.0 / ((3 * n - 2) * (3 * n + 1));
                sum += term;
                n++;
            }
            // for 0,002000 eps, ans: 0,320000
            System.out.printf("for %f eps, ans: %f", epsilon, sum);
        }
    }
}
