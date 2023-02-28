import java.util.Scanner;

public class Titov_Pavel_3_1 {
    public static void main(String[] args) throws Exception {
        try (Scanner input = new Scanner(System.in)) {
            System.out.print("number: ");
            int number = input.nextInt();

            int numDigits = 0;

            for (int i = number; i != 0; i /= 10) {
                numDigits++;
            }
            System.out.printf("это %d значное число", numDigits);
        }
    }
}
