import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);

        int numeroSecreto = (int) (Math.random() * 100);
        int intento;

        System.out.println("¡Comienza el juego!");
        System.out.println("Tienes que adivinar el número secreto, este se encuentra entre 0 y 99.");
        System.out.println("Si en algún momento quieres rendirte, introduce '-1'");
        System.out.println("Introduce un número: ");
        intento = entrada.nextInt();

        while (numeroSecreto != intento) {
            if (intento == -1) {
                System.out.println("Has abandonado.");
                break;
            } else if (numeroSecreto < intento) {
                System.out.println("El número introducido es menor.");
                System.out.println("Introduce otro número: ");
                intento = entrada.nextInt();
            } else if (numeroSecreto > intento) {
                System.out.println("El número introducido es mayor.");
                System.out.println("Introduce otro número: ");
                intento = entrada.nextInt();
            }
        }

        if (numeroSecreto == intento) {
            System.out.println("¡Felicidades! Has adivinado el número secreto.");
        }
    }
}
