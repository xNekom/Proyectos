import java.util.Scanner;

public class Main {

    // Rellena una matriz de caracteres con '~'.
    public static void llenarMatrices(char[][] matriz) {
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                matriz[i][j] = '~';
            }
        }
    }

    // Imprime los dos tableros de juego en la pantalla.
    public static void mostrarMatrices(char[][] tableroPj1, char[][] tableroPj2) {

        System.out.println("Tablero jugador 1" + "        \t " + "Tablero jugador 2");

        // Imprimir los números en la parte superior
        System.out.print("   "); // Espacios para alinear los números
        for (int j = 1; j <= 10; j++) {
            System.out.print(j + " ");
        }
        System.out.print("        ");
        for (int j = 1; j <= 10; j++) {
            System.out.print(j + " ");
        }
        System.out.println();

        // Imprimir las letras a la izquierda y los tableros
        for (int i = 0; i < 10; i++) {
            System.out.print(" " + (char) ('A' + i) + " ");
            for (int j = 0; j < 10; j++) {
                System.out.print(tableroPj1[i][j] + " ");
            }
            System.out.print("      ");
            System.out.print(" " + (char) ('A' + i) + " ");
            for (int j = 0; j < 10; j++) {
                System.out.print(tableroPj2[i][j] + " ");
            }
            System.out.println();
        }
    }

    public static void colocarBarcos(char[][] matrizBarcos, int jugador, int longitudBarco, char simboloBarco) {
        Scanner scanner = new Scanner(System.in);
        int buffer = 2; // Distancia mínima entre barcos

        while (true) {
            System.out.println("Jugador " + jugador + ", introduce la coordenada inicial (A1-J10): ");
            String coordenada = scanner.nextLine().toLowerCase(); // Convertir a minúsculas

            int fila = convertirFilaALetra(coordenada.charAt(0));
            int columna;

            try {
                columna = convertirCoordenadaANumero(coordenada.charAt(1));
            } catch (NumberFormatException e) {
                System.out.println("Coordenada no válida. Debe introducir una letra seguida de un número entre 1 y 10.");
                continue;
            }

            if (fila < 0 || fila >= matrizBarcos.length || columna < 0 || columna >= matrizBarcos[0].length) {
                System.out.println("Coordenada no válida. La coordenada debe estar dentro del tablero (A1-J10).");
                continue;
            }

            System.out.println("¿Desea colocar el barco verticalmente (H) o horizontalmente (V)?");
            String orientacion = scanner.nextLine();

            if (!orientacion.equalsIgnoreCase("H") && !orientacion.equalsIgnoreCase("V")) {
                System.out.println("Orientación no válida. Debe elegir H para vertical o V para horizontal.");
                continue;
            }

            boolean espacioLibre = true;

            for (int i = buffer; i < longitudBarco + buffer; i++) {
                int filaBarco = fila;
                int columnaBarco = columna;

                if (orientacion.equalsIgnoreCase("V")) {
                    columnaBarco += i - buffer;
                } else {
                    filaBarco += i - buffer;
                }

                if (filaBarco < 0 || filaBarco >= matrizBarcos.length || columnaBarco < 0 || columnaBarco >= matrizBarcos[0].length) {
                    espacioLibre = false;
                    break;
                }

                // Comprobar casillas adyacentes
                for (int j = -1; j <= 1; j++) {
                    for (int k = -1; k <= 1; k++) {
                        int filaAdyacente = filaBarco + j;
                        int columnaAdyacente = columnaBarco + k;

                        if (filaAdyacente >= 0 && filaAdyacente < matrizBarcos.length && columnaAdyacente >= 0 && columnaAdyacente < matrizBarcos[0].length) {
                            if (matrizBarcos[filaAdyacente][columnaAdyacente] != '~') {
                                espacioLibre = false;
                                break;
                            }
                        }
                    }

                    if (!espacioLibre) {
                        break;
                    }
                }

                if (!espacioLibre) {
                    break;
                }
            }

            if (!espacioLibre) {
                System.out.println("No se puede colocar el barco en esa posición. Espacio ocupado o demasiado cerca de otro barco.");
                continue;
            }

            for (int i = 0; i < longitudBarco; i++) {
                int filaBarco = fila;
                int columnaBarco = columna;
                if (orientacion.equalsIgnoreCase("H")) {
                    columnaBarco += i;
                } else {
                    filaBarco += i;
                }

                matrizBarcos[filaBarco][columnaBarco] = simboloBarco;
            }
            break;
        }
    }


    private static int convertirCoordenadaANumero(char numero) throws NumberFormatException {
        return numero - '1';
    }

    // Función para convertir una letra a un número de fila.
    private static int convertirFilaALetra(char letra) {
        switch (letra) {
            case 'a':
                return 0;
            case 'b':
                return 1;
            case 'c':
                return 2;
            case 'd':
                return 3;
            case 'e':
                return 4;
            case 'f':
                return 5;
            case 'g':
                return 6;
            case 'h':
                return 7;
            case 'i':
                return 8;
            case 'j':
                return 9;
            default:
                return -1;
        }
    }

    // Realiza un turno de juego para un jugador.
    public static void turnoJugador(char[][] tableroJugador, char[][] barcosJugador) {
        Scanner sc = new Scanner(System.in);

        while (true) {
            System.out.println("Introduce la coordenada (A0-J9): ");
            String coordenada = sc.nextLine();

            int x = convertirFilaALetra(coordenada.charAt(0));
            int y = convertirCoordenadaANumero(coordenada.charAt(1));

            if (x < 0 || x >= 10 || y < 0 || y >= 10) {
                System.out.println("Coordenada inválida. Introduce una dentro del rango (A0-J9).");
                continue;
            }

            if (barcosJugador[x][y] == '~') {
                tableroJugador[x][y] = 'O';
                barcosJugador[x][y] = 'O';
                System.out.println("Has fallado!");
            } else if (barcosJugador[x][y] == 'O' || barcosJugador[x][y] == 'X') {
                System.out.println("Ya has disparado a esa coordenada.");
            } else {
                tableroJugador[x][y] = 'X';
                barcosJugador[x][y] = 'X';
                System.out.println("Has acertado!");
            }
            break;
        }
    }

    // Comprueba si un jugador ha ganado.
    public static boolean comprobarVictoria(char[][] matrizBarcos, int jugador) {
        boolean victoria = false;
        int contador = 0;
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                if (matrizBarcos[i][j] == 'X') {
                    contador++;
                }
            }
        }

        // Ajusta la condición de victoria según la configuración de barcos
        if (jugador == 1) {
            victoria = contador == 15;   // Jugador 1 tiene 5 barcos (5+4+2*3+2)
        } else {
            victoria = contador == 14;   // Jugador 2 tiene 4 barcos (4+3+2*2+2)
        }

        if (victoria) {
            System.out.println("El jugador " + jugador + " ha ganado!");
        }
        return victoria;
    }

    // Función principal.
    public static void main(String[] args) throws Exception {

        char[][] tableroPj1 = new char[10][10];
        char[][] tableroPj2 = new char[10][10];

        llenarMatrices(tableroPj1);
        llenarMatrices(tableroPj2);

        mostrarMatrices(tableroPj1, tableroPj2);

        // Colocar barcos

        // **Seleccionar y colocar barcos por nombre**

        // Opciones de barcos
        String[] opcionesBarcos = {"Portaaviones", "Acorazado", "Destructor", "Submarino"};

        // Barcos restantes para cada jugador
        int[] barcosDisponiblesPj1 = {1, 1, 2, 1};
        int[] barcosDisponiblesPj2 = {1, 1, 2, 1};

        for (int jugador = 1; jugador <= 2; jugador++) {
            System.out.println("Jugador " + jugador + ", ¿qué barcos quieres colocar?");
            for (int i = 0; i < opcionesBarcos.length; i++) {
                if (barcosDisponiblesPj1[i] > 0) {
                    System.out.println(i + 1 + ". " + opcionesBarcos[i] + " (" + barcosDisponiblesPj1[i] + " disponibles)");
                }
            }

            boolean colocarBarco = true;
            while (colocarBarco) {
                Scanner sc = new Scanner(System.in);
                System.out.print("Selecciona el barco (introduce el número o 0 para terminar): ");
                int eleccionBarco = sc.nextInt();

                if (eleccionBarco == 0) {
                    colocarBarco = false;
                    break;
                }

                if (eleccionBarco < 1 || eleccionBarco > opcionesBarcos.length || barcosDisponiblesPj1[eleccionBarco - 1] == 0) {
                    System.out.println("Opción inválida o barco no disponible.");
                    continue;
                }

                // Obtiene la longitud y símbolo del barco elegido
                int longitudBarco = 0;
                char simboloBarco = 0;
                switch (eleccionBarco) {
                    case 1:
                        longitudBarco = 5;
                        simboloBarco = 'P';
                        break;
                    case 2:
                        longitudBarco = 4;
                        simboloBarco = 'A';
                        break;
                    case 3:
                        longitudBarco = 3;
                        simboloBarco = 'D';
                        break;
                    case 4:
                        longitudBarco = 2;
                        simboloBarco = 'S';
                        break;
                }

                // Coloca el barco en el tablero del jugador actual
                colocarBarcos(jugador == 1 ? tableroPj1 : tableroPj2, jugador, longitudBarco, simboloBarco);

                // Reduce la disponibilidad del barco colocado
                barcosDisponiblesPj1[eleccionBarco - 1]--;

                mostrarMatrices(tableroPj1, tableroPj2);
            }
        }

        int turno = 0; // 0 = jugador 1, 1 = jugador 2
        boolean victoria = false;

        while (!victoria) {
            if (turno == 0) {
                System.out.println("Turno del jugador 1");
                turnoJugador(tableroPj1, tableroPj2);
                turno = 1;
                mostrarMatrices(tableroPj1, tableroPj2);
                victoria = comprobarVictoria(tableroPj2, 1);
            } else {
                System.out.println("Turno del jugador 2");
                turnoJugador(tableroPj2, tableroPj1);
                turno = 0;
                mostrarMatrices(tableroPj1, tableroPj2);
                victoria = comprobarVictoria(tableroPj1, 2);
            }
        }
    }
}
