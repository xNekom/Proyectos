package Models;

import java.util.Scanner;

public class MaquinaExpendedora {
    private Inventario inventario;
    private Caja caja;
    private Dispensador dispensador;
    private Scanner scanner;

    public MaquinaExpendedora(Moneda[] monedas, Producto[] productos) {
        this.inventario = new Inventario(monedas, productos);
        this.caja = new Caja();
        this.dispensador = new Dispensador(inventario, caja, this);
        this.scanner = new Scanner(System.in);
    }

    // Método principal para ejecutar la máquina expendedora
    public void run() {
        boolean salir = false;
        while (!salir) {
            mostrarProductos();
            int indiceProducto = seleccionarProducto();

            if (indiceProducto == 7777) {
                mostrarMenuMantenimiento();
                continue;
            } else if (indiceProducto == -1) {
                salir = true;
                continue;
            } else if (indiceProducto == -2) {
                // Código incorrecto fuera de rango
                System.out.println("Código de producto incorrecto. Por favor, introduzca un código válido.");
                continue;
            }

            int importeAcumulado = 0;
            boolean productoDispensado = false;
            while (!productoDispensado && !salir) {
                int importe = solicitarImporte();
                if (importe == 0) {
                    System.out.println("Devolución de monedas: " + (importeAcumulado / 100.0) + " Euros.");
                    salir = true;
                    break;
                } else {
                    importeAcumulado += importe;
                    productoDispensado = dispensador.acumularImporteYDispensarProducto(indiceProducto, importeAcumulado);
                    if (productoDispensado || importeAcumulado >= inventario.getProducto(indiceProducto).getPrecio()) {
                        continue;
                    }
                }
            }
        }
    }

    private int solicitarCodigo() {
        System.out.print("Introduce un código (o -1 para salir): ");
        return scanner.nextInt();
    }

    // Muestra la lista de productos disponibles en la máquina
    private void mostrarProductos() {
        System.out.println("--------------------------------------------------------------------------------------------");
        Producto[] productos = inventario.getProductos();
        for (int i = 0; i < productos.length; i++) {
            System.out.println(i + ". " + productos[i].getNombre() + " " + (productos[i].getPrecio() / 100.0) + " Euros " + productos[i].getCantidad() + " unidades");
        }
        System.out.println("--------------------------------------------------------------------------------------------");
        System.out.println("Elige un producto:");
    }

    // Devuelve el índice del producto seleccionado, -1 para salir, o -2 para código no válido
    private int seleccionarProducto() {
        int codigoIntroducido = solicitarCodigo();
        if (codigoIntroducido == 7777) {
            return 7777;
        } else if (codigoIntroducido == -1) {
            return -1;
        } else if (codigoIntroducido < 0 || codigoIntroducido >= inventario.getProductos().length) {
            return -2;  // Código no válido
        } else {
            return codigoIntroducido;
        }
    }

    // Solicitar importe al usuario y devolver su valor en céntimos
    public int solicitarImporte() {
        while (true) {
            System.out.print("Introduce una moneda (10, 20, 50 céntimos, 1€, 2€): ");
            int importe = scanner.nextInt();
            switch (importe) {
                case 10:
                case 20:
                case 50:
                    return importe;
                case 1:  // 1 euro
                    return 100;  // 1 euro es igual a 100 céntimos
                case 2:  // 2 euros
                    return 200;  // 2 euros es igual a 200 céntimos
                default:
                    System.out.println("Moneda no reconocida. Introduce una moneda válida.");
                    continue;
            }
        }
    }

    public int solicitarNuevaMoneda() {
        while (true) {
            System.out.print("Introduce una moneda (10, 20, 50 céntimos, 1€, 2€): ");
            int importe = scanner.nextInt();
            switch (importe) {
                case 10:
                case 20:
                case 50:
                    return importe;
                case 1:  // 1 euro
                    return 100;  // 1 euro es igual a 100 céntimos
                case 2:  // 2 euros
                    return 200;  // 2 euros es igual a 200 céntimos
                default:
                    System.out.println("Moneda no reconocida. Introduce una moneda válida.");
                    continue;
            }
        }
    }

    // Mostrar el menú de mantenimiento
    private void mostrarMenuMantenimiento() {
        boolean salirMenu = false;
        while (!salirMenu) {
            System.out.println("*** Menú de mantenimiento ***");
            System.out.println("1. Introducir productos");
            System.out.println("2. Introducir monedas");
            System.out.println("3. Recaudación");
            System.out.println("0. Salir");
            System.out.print("Elige opción: ");
            int opcion = scanner.nextInt();

            switch (opcion) {
                case 1:
                    introducirProductos();
                    break;
                case 2:
                    introducirCambios();
                    break;
                case 3:
                    mostrarRecaudacion();
                    break;
                case 0:
                    salirMenu = true;
                    break;
                default:
                    System.out.println("Opción no válida");
                    break;
            }
        }
    }

    private void introducirProductos() {
        System.out.print("Introduce el número del producto: ");
        int indiceProducto = scanner.nextInt();
        System.out.print("Introduce la cantidad: ");
        int cantidad = scanner.nextInt();
        if (indiceProducto >= 0 && indiceProducto < inventario.getProductos().length) {
            inventario.actualizarProducto(indiceProducto, cantidad);
            System.out.println("Producto actualizado.");
        } else {
            System.out.println("Índice de producto no válido.");
        }
    }

    // Introducir monedas para cambios
    private void introducirCambios() {
        System.out.print("Introduce el valor de la moneda (en céntimos, ej. 10, 20, 50, 100, 200): ");
        int valor = scanner.nextInt();
        System.out.print("Introduce la cantidad: ");
        int cantidad = scanner.nextInt();
        int indiceMoneda = obtenerIndicePorValor(valor);
        if (indiceMoneda != -1) {
            inventario.actualizarMoneda(indiceMoneda, cantidad);
            System.out.println("Cambios actualizados.");
        } else {
            System.out.println("Valor de moneda no válido.");
        }
    }

    // Mostrar la recaudación
    private void mostrarRecaudacion() {
        System.out.println("Recaudación total: " + (caja.getRecaudacion() / 100.0) + " Euros");
        System.out.println("Detalle de monedas en la máquina:");
        for (Moneda moneda : inventario.getMonedas()) {
            System.out.println(moneda.getCantidad() + " moneda(s) de " + (moneda.getValor() / 100.0) + " Euros");
        }
    }

    private int obtenerIndicePorValor(int valor) {
        switch (valor) {
            case 10:
                return 0;
            case 20:
                return 1;
            case 50:
                return 2;
            case 100:
                return 3;
            case 200:
                return 4;
            default:
                System.out.println("Valor de moneda no reconocido.");
                return -1;
        }
    }
}