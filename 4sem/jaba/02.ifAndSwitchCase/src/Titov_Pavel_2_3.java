import java.util.Scanner;

public class Titov_Pavel_2_3 {
    public static void main(String[] args) throws Exception {
        try (Scanner input = new Scanner(System.in)) {
            System.out.print("TYPE (1-дней, 2-часов, 3-минут, 4-секунд): ");
            int timeType = input.nextInt();
            System.out.print("V: ");
            int V = input.nextInt();
            switch (timeType) {
                case 1:
                    System.out.printf("Answer: %d", V * 86400);
                    break;
                case 2:
                    System.out.printf("Answer: %d", V * 3600);
                    break;
                case 3:
                    System.out.printf("Answer: %d", V * 60);
                    break;
                case 4:
                    System.out.printf("Answer: %d", V);
                    break;
                default:
                    System.out.println("Wrong type bro");
                    break;
            }
        }
    }
}
]