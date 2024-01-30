import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Introduce un número binario:");
        String cadenaBinario = scanner.nextLine();
        // Convertimos el número binario a decimal utilizando nuestra función
        int decimal = binarioADecimal(cadenaBinario);
        // Imprimimos el resultado
        System.out.println("El número decimal correspondiente es: " + decimal);
    }

    // Esta función convierte un número binario (en forma de cadena) a decimal
    public static int binarioADecimal(String cadenaBinario) {
        // Inicializamos el número decimal a 0
        int decimal = 0;
        // Obtenemos la longitud de la cadena binaria
        int n = cadenaBinario.length();
        // Recorremos la cadena de derecha a izquierda
        for (int i = 0; i < n; i++) {
            // Obtenemos el bit en la posición i desde el final
            char bit = cadenaBinario.charAt(n - 1 - i);
            // Si el bit es '1', lo sumamos al número decimal
            if (bit == '1') {
                decimal += (int) Math.pow(2, i);
            }
        }
        // Devolvemos el número decimal
        return decimal;
    }
}