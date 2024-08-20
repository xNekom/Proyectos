package Models;

public class Moneda {
    private int valor;
    private int cantidad;

    public Moneda(int valor, int cantidad) {
        this.valor = valor;
        this.cantidad = cantidad;
    }

    public int getValor() {
        return valor;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }
}