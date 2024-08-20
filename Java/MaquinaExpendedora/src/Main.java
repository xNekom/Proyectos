import Models.*;

public class Main {
    public static void main(String[] args) {
        Moneda[] monedas = {
                new Moneda(100, 20),
                new Moneda(200, 15),
                new Moneda(10, 50),
                new Moneda(20, 40),
                new Moneda(50, 30)
        };

        Producto[] productos = {
                new Producto("Agua", 50, 25),
                new Producto("Coca-Cola", 120, 15),
                new Producto("Sandwich", 200, 10),
                new Producto("Chocolate", 80, 20),
                new Producto("Galletas", 60, 30)
        };

        MaquinaExpendedora maquinaExpendedora = new MaquinaExpendedora(monedas, productos);

        maquinaExpendedora.run();
    }
}