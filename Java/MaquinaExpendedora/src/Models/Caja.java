package Models;

public class Caja {
    private int recaudacion;

    public void agregarRecaudacion(int monto) {
        recaudacion += monto;
    }

    public int getRecaudacion() {
        return recaudacion;
    }
}
