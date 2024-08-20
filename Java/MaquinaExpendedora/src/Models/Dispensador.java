package Models;

public class Dispensador {
    private Inventario inventario;
    private Caja caja;
    private MaquinaExpendedora maquinaExpendedora;

    public Dispensador(Inventario inventario, Caja caja, MaquinaExpendedora maquinaExpendedora) {
        this.inventario = inventario;
        this.caja = caja;
        this.maquinaExpendedora = maquinaExpendedora;
    }

    public boolean acumularImporteYDispensarProducto(int indiceProducto, int importe) {
        Producto producto = inventario.getProducto(indiceProducto);
        int precio = producto.getPrecio();
        int acumulado = importe;

        // Si al inicio el importe introducido ya es suficiente, dispensar directamente
        if (acumulado >= precio) {
            return dispensarProducto(indiceProducto, acumulado);
        }

        System.out.println("Importe acumulado: " + (acumulado / 100.0) + " Euros. Faltan " + ((precio - acumulado) / 100.0) + " Euros.");
        while (acumulado < precio) {
            System.out.println("Introduzca más monedas: ");
            int nuevaMoneda = maquinaExpendedora.solicitarNuevaMoneda();
            acumulado += nuevaMoneda;
            System.out.println("Importe acumulado: " + (acumulado / 100.0) + " Euros. Faltan " + (Math.max(0, precio - acumulado) / 100.0) + " Euros.");
        }

        return dispensarProducto(indiceProducto, acumulado);
    }

    public boolean dispensarProducto(int indiceProducto, int importeTotal) {
        Producto producto = inventario.getProducto(indiceProducto);
        int precio = producto.getPrecio();
        int cambio = importeTotal - precio;

        if (cambio >= 0) {
            producto.setCantidad(producto.getCantidad() - 1);
            caja.agregarRecaudacion(precio);
            if (cambio > 0) {
                dispensarCambio(cambio);
            }
            System.out.println("Puede coger su " + producto.getNombre());
            System.out.println("Su cambio: " + (cambio / 100.0) + " Euros");
            return true;
        } else {
            System.out.println("Importe insuficiente. Introduzca más dinero.");
            return false;
        }
    }

    private void dispensarCambio(int cambio) {
        System.out.println("Dispensando cambio...");
        int[] denominaciones = {200, 100, 50, 20, 10};
        for (int denominacion : denominaciones) {
            int cantidad = cambio / denominacion;
            while (cantidad > 0) {
                int indiceMoneda = obtenerIndicePorValor(denominacion);
                if (indiceMoneda >= 0) {
                    Moneda moneda = inventario.getMoneda(indiceMoneda);
                    if (moneda.getCantidad() > 0) {
                        int numMonedasDispensar = Math.min(cantidad, moneda.getCantidad());
                        moneda.setCantidad(moneda.getCantidad() - numMonedasDispensar);
                        System.out.println(numMonedasDispensar + " moneda(s) de " + (denominacion / 100.0) + " Euros");
                        cambio -= numMonedasDispensar * denominacion;
                        cantidad -= numMonedasDispensar;
                    } else {
                        System.out.println("No hay monedas de " + (denominacion / 100.0) + " Euros disponibles para cambio.");
                        break;
                    }
                } else {
                    System.out.println("No hay monedas de " + (denominacion / 100.0) + " Euros disponibles");
                    break;
                }
            }
            if (cambio == 0) break;
        }

        if (cambio > 0) {
            System.out.println("No se pudo dispensar el cambio completo. Faltante: " + (cambio / 100.0) + " Euros.");
        }
    }

    private int obtenerIndicePorValor(int valor) {
        switch (valor) {
            case 10:
                return 2;
            case 20:
                return 3;
            case 50:
                return 4;
            case 100:
                return 0;
            case 200:
                return 1;
            default:
                System.out.println("Valor de moneda no reconocido.");
                return -1;
        }
    }
}