import java.util.*;

public class Main {
    public static void main(String[] args) {

        Scanner entrada = new Scanner(System.in);
        System.out.print("¿Por cuántos dígitos está formado el número que hay que adivinar? ");
        int cantNum = entrada.nextInt();
        System.out.print("¿Cuántos intentos hay para acertar el número del oponente? ");
        int cantIntentos = entrada.nextInt();
        System.out.println("\nATENCIÓN JUGADOR 2: NO MIRES\n");
        System.out.print("JUGADOR 1\nIntroduce tu número de " + cantNum
                + " cifras.\nLos espacios a la izquierda no rellenos se considerarán ceros\n"
                + ". En caso de pasarte de dígitos, se cogerán los " + cantNum + " últimos ");
        int num = entrada.nextInt();
        int tJugUno[] = convierteATabla(num, cantNum);
        System.out.println("\nATENCIÓN JUGADOR 1: NO MIRES\n");
        System.out.print("JUGADOR 2\nIntroduce tu número de " + cantNum
                + " cifras.\nLos espacios a la izquierda no rellenos se considerarán ceros ");
        num = entrada.nextInt();
        int tJugDos[] = convierteATabla(num, cantNum);
        int[] tablaHistoricoJugUno = new int[0];
        int[] tablaHistoricoJugDos = new int[0];
        int intentos = 0;
        int apuestaJugUno = -1;
        int apuestaJugDos = -1;

        do { // si hay un -1 al final de tablaHistorico fin de la partida

            System.out.println("Turno " + intentos + "\n. Jugador 1 haz tu apuesta\n");
            apuestaJugUno = entrada.nextInt();
            int tJugUnoApuesta[] = convierteATabla(apuestaJugUno, cantNum);
            tablaHistoricoJugUno = resuelveMuertosHeridos(tJugDos, tJugUnoApuesta, cantNum, tablaHistoricoJugUno);
            System.out.print("Historial del J1: ");
            System.out.println(Arrays.toString(tablaHistoricoJugUno));


            System.out.println("Turno " + intentos + ". Jugador 2 haz tu apuesta\n");
            apuestaJugDos = entrada.nextInt();
            int tJugDosApuesta[] = convierteATabla(apuestaJugDos, cantNum);
            tablaHistoricoJugDos = resuelveMuertosHeridos(tJugUno, tJugDosApuesta, cantNum, tablaHistoricoJugDos);
            System.out.print("Historial del J2: ");
            System.out.println(Arrays.toString(tablaHistoricoJugDos));


            intentos++;
        } while ((intentos < cantIntentos) && (tablaHistoricoJugUno[tablaHistoricoJugUno.length - 1] != -1)
                && (tablaHistoricoJugDos[tablaHistoricoJugDos.length - 1] != -1));

        if ((tablaHistoricoJugUno[tablaHistoricoJugUno.length - 3] == cantNum) && (tablaHistoricoJugDos[tablaHistoricoJugDos.length - 3] == cantNum)) {
            System.out.println("Empate, ambos jugadores ganan");
            System.out.print("Historial del J1: ");
            System.out.println(Arrays.toString(tablaHistoricoJugUno));
            System.out.print("Historial del J2: ");
            System.out.println(Arrays.toString(tablaHistoricoJugDos));
        } else if ((tablaHistoricoJugUno[tablaHistoricoJugUno.length - 3] == cantNum)) {
            System.out.println("Jugador 1 gana");
            System.out.print("Historial del J1: ");
            System.out.println(Arrays.toString(tablaHistoricoJugUno));
            System.out.print("Historial del J2: ");
            System.out.println(Arrays.toString(tablaHistoricoJugDos));
        } else if (tablaHistoricoJugDos[tablaHistoricoJugDos.length - 3] == cantNum) {
            System.out.println("Jugador 2 gana");
            System.out.print("Historial del J1: ");
            System.out.println(Arrays.toString(tablaHistoricoJugUno));
            System.out.print("Historial del J2: ");
            System.out.println(Arrays.toString(tablaHistoricoJugDos));
        } else {
            System.out.println("Se han acabado los intentos.\nEstas son vuestras tiradas:\n");
            System.out.print("Historial del J1: ");
            System.out.println(Arrays.toString(tablaHistoricoJugUno));
            System.out.print("Historial del J2: ");
            System.out.println(Arrays.toString(tablaHistoricoJugDos));
            System.out.println("FIN DE LA PARTIDA");
        }
    }

    static int[] convierteATabla(int numUno, int cantNum) {
        int numUnoAux = numUno;
        int t1[] = new int[cantNum];
        for (int i = 0; i < cantNum; i++) {
            int digito = numUnoAux % 10;
            numUnoAux = numUnoAux / 10;
            t1[t1.length - 1 - i] = digito;
        }
        return t1;
    }

    static int[] resuelveMuertosHeridos(int[] original, int[] apuesta, int cantNum, int[] tablaHistorico) {
        boolean noEncontrado = true;
        int muertos = 0;
        int heridos = 0;
        int tablaAuxOriginal[] = Arrays.copyOf(original, cantNum);
        int tablaAuxApuesta[] = Arrays.copyOf(apuesta, cantNum);
        tablaHistorico = Arrays.copyOf(tablaHistorico, tablaHistorico.length + cantNum + 3);
        System.arraycopy(tablaAuxApuesta, 0, tablaHistorico, tablaHistorico.length - cantNum - 3, cantNum);
        for (int i = 0; i < cantNum; i++) { // compruebo los muertos
            if (tablaAuxOriginal[cantNum - 1 - i] == tablaAuxApuesta[cantNum - 1 - i]) {//desde el final de la tabla hasta el principio
                muertos = muertos + 1;
                int indiceTabla = cantNum - 1 - i;
                System.arraycopy(tablaAuxOriginal, indiceTabla + 1, tablaAuxOriginal, indiceTabla, tablaAuxOriginal.length - indiceTabla - 1);//movemos una posición
//hacia la izquierda los elementos siguientes al elemento que evaluamos para macharcarlo
                tablaAuxOriginal = Arrays.copyOf(tablaAuxOriginal, tablaAuxOriginal.length - 1);//quitamos el
//registro que sobra del paso anterior
                System.arraycopy(tablaAuxApuesta, indiceTabla + 1, tablaAuxApuesta, indiceTabla, tablaAuxApuesta.length - indiceTabla - 1);//lo mismo con la tabla de la apuesta
                tablaAuxApuesta = Arrays.copyOf(tablaAuxApuesta, tablaAuxApuesta.length - 1);
            }
        }
        System.out.println(Arrays.toString(tablaAuxOriginal));
        System.out.println(Arrays.toString(tablaAuxApuesta));
        for (int j = 0; j < tablaAuxApuesta.length; j++) {//compruebo los heridos
            noEncontrado = true;
            for (int k = 0; ((k < tablaAuxOriginal.length) & (noEncontrado = true)); k++) {
                if (tablaAuxApuesta[j] == tablaAuxOriginal[k]) {
                    heridos = heridos + 1;
                    noEncontrado = false;
// elimino el elemento encontrado de la tablaAuxOriginal
                    System.arraycopy(tablaAuxOriginal, k + 1, tablaAuxOriginal, k, tablaAuxOriginal.length - k - 1);
                    tablaAuxOriginal = Arrays.copyOf(tablaAuxOriginal, tablaAuxOriginal.length - 1);

                }
            }
        }
        System.out.println("M: " + muertos + "\nH:" + heridos);
        tablaHistorico[tablaHistorico.length - 2] = heridos;
        tablaHistorico[tablaHistorico.length - 3] = muertos;
        tablaHistorico[tablaHistorico.length - 1] = -10; // -10 sigue la partida

        if (muertos == cantNum) {
            tablaHistorico[tablaHistorico.length - 1] = -1; // finaliza la partida, se ha adivinado el número
            System.out.print("BIEN!, has acertado el número de tu contrincante\n");
        }
        return tablaHistorico;
    }
}