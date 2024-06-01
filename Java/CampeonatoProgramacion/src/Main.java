import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        int puntos[] = new int[5];
        for (int i = 0; i < 5; i++) {
            System.out.print("Puntos programador (" + (i + 1) + "): ");
            puntos[i] = entrada.nextInt();
        }
        Arrays.sort(puntos);
        System.out.println("Puntuacion: " + Arrays.toString(puntos));
        System.out.print("Puntos del programador de exhibición: ");

        int puntosProgExh = entrada.nextInt();
        while (puntosProgExh != -1) {
            puntos = Arrays.copyOf(puntos, puntos.length + 1);
            puntos[puntos.length - 1] = puntosProgExh;
            System.out.print("Puntos del programador de exhibición: ");
            puntosProgExh = entrada.nextInt();
        }

        Arrays.sort(puntos);
        System.out.print("Puntuación final: " + Arrays.toString(puntos));
    }
}