import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Preguntar tipo de cliente
        System.out.println("Introduce el tipo de cliente (1: Jubilados, 2: Menores de edad, 3: No jubilados):");
        int tipoCliente = scanner.nextInt();

        // Preguntar tipo de solicitud
        System.out.println("Introduce el tipo de solicitud (1: Sacar dinero, 2: Ingresar dinero):");
        int tipoSolicitud = scanner.nextInt();

        // Condicionales
        if (tipoCliente == 1) {
            if (tipoSolicitud == 1) {
                System.out.println("Los jubilados sacan dinero en la ventanilla 10.");
            } else if (tipoSolicitud == 2) {
                System.out.println("Los jubilados ingresan dinero en la ventanilla 11.");
            }
        } else if (tipoCliente == 2) {
            System.out.println("Vete a casa");
        } else if (tipoCliente == 3) {
            if (tipoSolicitud == 1) {
                System.out.println("Los no jubilados sacan dinero en el cajero.");
            } else if (tipoSolicitud == 2) {
                System.out.println("Los no jubilados ingresan dinero en la ventanilla 12.");
            }
        } else {
            System.out.println("Tipo de cliente no válido.");
        }
    }
}
