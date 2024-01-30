import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.println("Longitud de la combinación secreta: ");
        int longitud = entrada.nextInt();
        int combSecreta[] = new int[longitud];
        int combJugador[] = new int[longitud];
        generarCombinacion(combSecreta);

        System.out.println("Escriba una combinación");
        leerTabla(combJugador);

        while (!Arrays.equals(combSecreta, combJugador)) {
            muestraPistas(combSecreta, combJugador);
            System.out.println("Escriba una combinación: ");
            leerTabla(combJugador);
        }
        System.out.println("¡La cámara está abierta!");
    }

    static void generarCombinacion(int t[]) {
        final int MAX = 5;
        for (int i = 0; i < t.length; i++) {
            t[i] = (int) (Math.random() * MAX + 1);
        }
    }

    static void leerTabla(int t[]) {
        Scanner entrada = new Scanner(System.in);
        for (int i = 0; i < t.length; i++) {
            t[i] = entrada.nextInt();
        }
    }

    static void muestraPistas(int secret[], int jug[]) {
        for (int i = 0; i < jug.length; i++) {
            System.out.print(jug[i]);
            if (secret[i] > jug[i]) {
                System.out.println(" mayor");
            } else if (secret[i] < jug[i]) {
                System.out.println(" menor");
            } else {
                System.out.println(" igual");
            }
        }
    }
}
