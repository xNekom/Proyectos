package Models;

public class Inventario {
    private Moneda[] monedas;
    private Producto[] productos;

    public Inventario(Moneda[] monedas, Producto[] productos) {
        this.monedas = monedas;
        this.productos = productos;
    }

    public Moneda getMoneda(int indice) {
        return monedas[indice];
    }

    public Producto getProducto(int indice) {
        return productos[indice];
    }

    public Producto[] getProductos() {
        return productos;
    }

    public Moneda[] getMonedas() {
        return monedas;
    }

    public void actualizarMoneda(int indice, int cantidad) {
        monedas[indice].setCantidad(cantidad);
    }

    public void actualizarProducto(int indice, int cantidad) {
        productos[indice].setCantidad(cantidad);
    }

    public void agregarMoneda(int indice, int cantidad) {
        monedas[indice].setCantidad(monedas[indice].getCantidad() + cantidad);
    }

    public void agregarProducto(Producto producto) {
        Producto[] nuevosProductos = new Producto[productos.length + 1];
        System.arraycopy(productos, 0, nuevosProductos, 0, productos.length);
        nuevosProductos[productos.length] = producto;
        this.productos = nuevosProductos;
    }
}