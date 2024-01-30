import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        int vida = 100;
        int turnos = 0;
        int bloqueosSeguidos = 0;

        while (vida > 0 && turnos < 15) {
            int alturaAtaque = (int) (Math.random() * 3);
            System.out.println("¡El monstruo ataca! ");
            System.out.println("Introduce la altura de bloqueo (0: baja, 1: media, 2: alta): ");
            int alturaBloqueo = entrada.nextInt();

            if (alturaAtaque == alturaBloqueo) {
                System.out.println("¡Has bloqueado el golpe!\n");
                bloqueosSeguidos++;
                if (bloqueosSeguidos == 3) {
                    vida = vida + 5;
                    bloqueosSeguidos = 0;
                    System.out.println("\n*****************************************************");
                    System.out.println("¡¡¡CHUTE DE ADRENALINA: Has ganado 5 puntos de vida!!!");
                    System.out.println("*****************************************************\n");
                }
            } else {
                int daño = (int) (Math.random() * 30) + 1;
                vida = vida - daño;
                bloqueosSeguidos = 0;
                System.out.println("\n¡Has fallado el bloqueo! La altura correcta era: " + alturaAtaque);
                System.out.println("Recibes " + daño + " puntos de daño\n");
            }
            turnos++;
            System.out.println("Vida restante: " + vida);
            System.out.println("Número de turnos: " + turnos);
        }
        System.out.println(
                "Juego finalizado. Has terminado con " + vida + " puntos de vida después de " + turnos + " turnos");
    }
}