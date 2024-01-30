import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int operacion;
        do {
            System.out.println("\nIntroduce la operación que quieres realizar.");
            System.out.println("Suma (1) - Resta (2) - Multiplicación (3) - División (4) - Salir (-1)");
            operacion = sc.nextInt();

            if (operacion < 1 || operacion > 4) {
                System.out.println("Operación no válida.");
                continue;
            }

            System.out.println("Introduce el primer número: ");
            int n1 = sc.nextInt();
            System.out.println("Introduce el segundo número: ");
            int n2 = sc.nextInt();

            System.out.println("El resultado es: " + operaciones(operacion, n1, n2));
        } while (operacion != -1);
    }

    public static int operaciones(int operacion, int n1, int n2) {
        switch (operacion) {
            case 1:
                return n1 + n2;
            case 2:
                return n1 - n2;
            case 3:
                return n1 * n2;
            case 4:
                return n1 / n2;
            default:
                return -1;
        }
    }
}
