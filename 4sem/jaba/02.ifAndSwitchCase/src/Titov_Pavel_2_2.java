import java.util.Scanner;

public class Titov_Pavel_2_2 {
    public static void main(String[] args) throws Exception {
        try (Scanner input = new Scanner(System.in)) {
            System.out.print("num: ");
            int num = input.nextInt();

            switch (num) {
                case 0:
                    System.out.println("ZERO");
                    break;
                case 1:
                    System.out.println("ONE");
                    break;
                case 2:
                    System.out.println("TWO");
                    break;
                case 3:
                    System.out.println("THREE");
                    break;
                case 4:
                    System.out.println("CHETIRE");
                    break;
                case 5:
                    System.out.println("PYAT");
                    break;
                case 6:
                    System.out.println("SHEST");
                    break;
                case 7:
                    System.out.println("SEM");
                    break;
                case 8:
                    System.out.println("VOSEM");
                    break;
                case 9:
                    System.out.println("DEVYAT");
                    break;
                default:
                    System.out.println("any num");
                    break;
            }
        }
    }
}
