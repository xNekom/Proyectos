import java.util.Scanner;

public class Main {

    // Constantes para el tamaño del tablero y los tipos de barcos
    public static final int TAM = 10;
    public static final char PORTAAVIONES = 'P';
    public static final char ACORAZADO = 'A';
    public static final char DESTRUCTOR = 'D';
    public static final char SUBMARINO = 'S';
    public static final char AGUA = '~';
    public static final char TOCADO = 'X';
    public static final char FALLADO = 'O';

    // Variables para almacenar los tableros y las flotas de cada jugador
    public static char[][] tablero1 = new char[TAM][TAM];
    public static char[][] tablero2 = new char[TAM][TAM];
    public static int flota1 = 15; // 5 + 4 + 3 + 3
    public static int flota2 = 15;

    // Objeto para leer la entrada del teclado
    public static Scanner sc = new Scanner(System.in);

    public static void main(String[] args) {
        // Inicializar los tableros con agua
        for (int i = 0; i < TAM; i++) {
            for (int j = 0; j < TAM; j++) {
                tablero1[i][j] = AGUA;
                tablero2[i][j] = AGUA;
            }
        }

        // Pedir a los jugadores que coloquen sus barcos
        System.out.println("Jugador 1, coloca tus barcos:");
        colocarBarcos(tablero1, 1);
        System.out.println("Jugador 2, coloca tus barcos:");
        colocarBarcos(tablero2, 2);

        // Variable para alternar el turno de cada jugador
        boolean turno1 = true;

        // Bucle principal del juego
        while (flota1 > 0 && flota2 > 0) {
            // Mostrar el tablero del jugador que tiene el turno
            if (turno1) {
                System.out.println("Turno del jugador 1");
                mostrarTablero(tablero1, true);
            } else {
                System.out.println("Turno del jugador 2");
                mostrarTablero(tablero2, true);
            }

            // Pedir las coordenadas del disparo al jugador
            System.out.println("Introduce las coordenadas del disparo (primero la columna y luego la fila):");
            char columna = sc.next().toUpperCase().charAt(0);
            int fila = sc.nextInt();

            // Comprobar si las coordenadas son válidas
            if (columna >= 'A' && columna <= 'J' && fila >= 1 && fila <= 10) {
                // Convertir la columna a un índice numérico
                int col = columna - 'A';

                // Restar uno a la fila para ajustarla al índice del array
                fila--;

                // Comprobar el resultado del disparo según el tablero del otro jugador
                if (turno1) {
                    disparar(tablero2, col, fila);
                } else {
                    disparar(tablero1, col, fila);
                }

                // Cambiar el turno si el disparo ha sido agua
                if (turno1) {
                    if (tablero2[fila][col] == FALLADO) {
                        turno1 = false;
                    }
                } else {
                    if (tablero1[fila][col] == FALLADO) {
                        turno1 = true;
                    }
                }
            } else {
                // Mostrar un mensaje de error si las coordenadas no son válidas
                System.out.println("Coordenadas inválidas. Inténtalo de nuevo.");
            }
        }

        // Mostrar el resultado final del juego
        if (flota1 == 0) {
            System.out.println("¡El jugador 2 ha ganado!");
        } else {
            System.out.println("¡El jugador 1 ha ganado!");
        }
    }

    // Método para pedir a un jugador que coloque sus barcos en un tablero
    public static void colocarBarcos(char[][] tablero, int jugador) {
        // Mostrar el tablero vacío
        mostrarTablero(tablero, false);

        // Pedir al jugador que coloque el portaaviones
        System.out.println("Coloca el portaaviones (ocupa 5 posiciones):");
        colocarBarco(tablero, PORTAAVIONES, 5);

        // Mostrar el tablero con el portaaviones
        mostrarTablero(tablero, false);

        // Pedir al jugador que coloque el acorazado
        System.out.println("Coloca el acorazado (ocupa 4 posiciones):");
        colocarBarco(tablero, ACORAZADO, 4);

        // Mostrar el tablero con el acorazado
        mostrarTablero(tablero, false);

        // Pedir al jugador que coloque los dos destructores
        System.out.println("Coloca el primer destructor (ocupa 3 posiciones):");
        colocarBarco(tablero, DESTRUCTOR, 3);

        // Mostrar el tablero con el primer destructor
        mostrarTablero(tablero, false);

        System.out.println("Coloca el segundo destructor (ocupa 3 posiciones):");
        colocarBarco(tablero, DESTRUCTOR, 3);

        // Mostrar el tablero con los dos destructores
        mostrarTablero(tablero, false);

        // Pedir al jugador que coloque el submarino
        System.out.println("Coloca el submarino (ocupa 2 posiciones):");
        colocarBarco(tablero, SUBMARINO, 2);

        // Mostrar el tablero con el submarino
        mostrarTablero(tablero, false);
    }

    // Método para pedir a un jugador que coloque un barco de un tipo y un tamaño dados en un tablero
    public static void colocarBarco(char[][] tablero, char tipo, int tam) {
        // Pedir al jugador que introduzca las coordenadas y la orientación del barco
        System.out.println("Introduce las coordenadas de la casilla inicial del barco (primero la columna y luego la fila):");
        char columna = sc.next().toUpperCase().charAt(0);
        int fila = sc.nextInt();
        System.out.println("Introduce la orientación del barco (0 = horizontal, 1 = vertical):");
        int orientacion = 0;
        boolean valido = false; // Usamos una variable booleana para controlar el bucle
        while (!valido) {
            if (sc.hasNextInt()) { // Comprobamos si el valor que se va a leer es un entero
                orientacion = sc.nextInt();
                if (orientacion == 0 || orientacion == 1) { // Comprobamos si el entero es 0 o 1
                    valido = true; // Si es así, salimos del bucle
                } else {
                    System.out.println("La orientación debe ser 0 o 1. Inténtalo de nuevo:");
                }
            } else { // Si el valor que se va a leer no es un entero
                System.out.println("La orientación debe ser un entero. Inténtalo de nuevo:");
                sc.next();
            }
        }


        // Comprobar si las coordenadas y la orientación son válidas
        if (columna >= 'A' && columna <= 'J' && fila >= 1 && fila <= 10 && (orientacion == 0 || orientacion == 1)) {
            // Convertir la columna a un índice numérico
            int col = columna - 'A';

            // Restar uno a la fila para ajustarla al índice del array
            fila--;

            // Comprobar si el barco cabe en el tablero según la orientación y las coordenadas
            boolean cabe = false;
            if (orientacion == 0) {
                // Horizontal
                if (col + tam <= TAM) {
                    cabe = true;
                }
            } else {
                // Vertical
                if (fila + tam <= TAM) {
                    cabe = true;
                }
            }

            // Comprobar si el barco no se solapa con otro barco ni está demasiado cerca
            boolean solapa = false;
            if (cabe) {
                if (orientacion == 0) {
                    // Horizontal
                    for (int i = col; i < col + tam; i++) {
                        if (tablero[fila][i] != AGUA) {
                            solapa = true;
                            break;
                        }
                        // Comprobar las casillas adyacentes
                        if (fila > 0 && tablero[fila - 1][i] != AGUA) {
                            solapa = true;
                            break;
                        }
                        if (fila < TAM - 1 && tablero[fila + 1][i] != AGUA) {
                            solapa = true;
                            break;
                        }
                        if (i == col && i > 0 && tablero[fila][i - 1] != AGUA) {
                            solapa = true;
                            break;
                        }
                        if (i == col + tam - 1 && i < TAM - 1 && tablero[fila][i + 1] != AGUA) {
                            solapa = true;
                            break;
                        }
                    }
                } else {
                    // Vertical
                    for (int i = fila; i < fila + tam; i++) {
                        if (tablero[i][col] != AGUA) {
                            solapa = true;
                            break;
                        }
                        // Comprobar las casillas adyacentes
                        if (col > 0 && tablero[i][col - 1] != AGUA) {
                            solapa = true;
                            break;
                        }
                        if (col < TAM - 1 && tablero[i][col + 1] != AGUA) {
                            solapa = true;
                            break;
                        }
                        if (i == fila && i > 0 && tablero[i - 1][col] != AGUA) {
                            solapa = true;
                            break;
                        }
                        if (i == fila + tam - 1 && i < TAM - 1 && tablero[i + 1][col] != AGUA) {
                            solapa = true;
                            break;
                        }
                    }
                }
            }

            // Si el barco cabe y no se solapa, colocarlo en el tablero
            if (cabe && !solapa) {
                if (orientacion == 0) {
                    // Horizontal
                    for (int i = col; i < col + tam; i++) {
                        tablero[fila][i] = tipo;
                    }
                } else {
                    // Vertical
                    for (int i = fila; i < fila + tam; i++) {
                        tablero[i][col] = tipo;
                    }
                }
                // Mostrar un mensaje de confirmación
                System.out.println("Has colocado un " + nombreBarco(tipo) + ".");
            } else {
                // Si el barco no cabe o se solapa, mostrar un mensaje de error y volver a intentarlo
                System.out.println("No puedes colocar el barco ahí. Inténtalo de nuevo.");
                colocarBarco(tablero, tipo, tam);
            }
        } else {
            // Si las coordenadas o la orientación no son válidas, mostrar un mensaje de error y volver a intentarlo
            System.out.println("Coordenadas u orientación inválidas. Inténtalo de nuevo.");
            colocarBarco(tablero, tipo, tam);
        }
    }

    // Método para mostrar un tablero por consola
    public static void mostrarTablero(char[][] tablero, boolean ocultar) {
        // Mostrar la primera fila con las letras de las columnas
        System.out.print("  ");
        for (char c = 'A'; c <= 'J'; c++) {
            System.out.print(c + " ");
        }
        System.out.println();

        // Mostrar el resto de filas con los números y el contenido del tablero
        for (int i = 0; i < TAM; i++) {
            System.out.print((i + 1) + " "); // Mostrar el número de la fila
            for (int j = 0; j < TAM; j++) {
                // Si el tablero se debe mostrar oculto, no mostrar los barcos que no han sido tocados
                if (ocultar && tablero[i][j] != AGUA && tablero[i][j] != TOCADO && tablero[i][j] != FALLADO) {
                    System.out.print(AGUA + " ");
                } else {
                    System.out.print(tablero[i][j] + " ");
                }
            }
            System.out.println();
        }
    }

    // Método para disparar a unas coordenadas dadas en un tablero
    public static void disparar(char[][] tablero, int col, int fila) {
        // Comprobar el contenido de la casilla
        char casilla = tablero[fila][col];
        switch (casilla) {
            case AGUA:
                // Si es agua, marcarla como fallado y mostrar un mensaje
                tablero[fila][col] = FALLADO;
                System.out.println("Has fallado. Agua.");
                break;
            case TOCADO:
            case FALLADO:
                // Si ya está tocado o fallado, mostrar un mensaje de error
                System.out.println("Ya has disparado a esa casilla. Inténtalo de nuevo.");
                break;
            default:
                // Si es un barco, marcarlo como tocado y mostrar un mensaje
                tablero[fila][col] = TOCADO;
                System.out.println("Has tocado un " + nombreBarco(casilla) + ".");
                // Reducir la flota del jugador correspondiente
                if (tablero == tablero1) {
                    flota1--;
                } else {
                    flota2--;
                }
                // Comprobar si el barco ha sido hundido
                if (barcoHundido(tablero, col, fila)) {
                    System.out.println("Has hundido un " + nombreBarco(casilla) + ".");
                }
                break;
        }
    }

    // Método para devolver el nombre de un barco según su tipo
    public static String nombreBarco(char tipo) {
        switch (tipo) {
            case PORTAAVIONES:
                return "portaaviones";
            case ACORAZADO:
                return "acorazado";
            case DESTRUCTOR:
                return "destructor";
            case SUBMARINO:
                return "submarino";
            default:
                return "barco desconocido";
        }
    }

    // Método para comprobar si un barco ha sido hundido
    public static boolean barcoHundido(char[][] tablero, int col, int fila) {
        // Obtener el tipo de barco
        char tipo = tablero[fila][col];

        // Comprobar las casillas adyacentes en las cuatro direcciones
        // Si hay alguna casilla con el mismo tipo de barco, no está hundido
        if (col > 0 && tablero[fila][col - 1] == tipo) {
            return false;
        }
        if (col < TAM - 1 && tablero[fila][col + 1] == tipo) {
            return false;
        }
        if (fila > 0 && tablero[fila - 1][col] == tipo) {
            return false;
        }
        if (fila < TAM - 1 && tablero[fila + 1][col] == tipo) {
            return false;
        }

        // Si no hay ninguna casilla adyacente con el mismo tipo de barco, está hundido
        return true;
    }
}
