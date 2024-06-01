import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        // Crear instancias de Camion y Furgoneta
        Camion c1 = new Camion("Volvo", "FH16", 2018, 20000, 90, "Carga pesada");
        Camion c2 = new Camion("Mercedes-Benz", "Actros", 2020, 18000, 85, "Carga a granel");
        Furgoneta f1 = new Furgoneta("Renault", "Master", 2016, 1500, 120, 8);
        Furgoneta f2 = new Furgoneta("Volkswagen", "Transporter", 2019, 1200, 110, 6);

        // Crear una instancia de GestorFlota y agregar los vehículos
        GestorFlota gestorFlota = new GestorFlota();
        gestorFlota.agregarVehiculo(c1);
        gestorFlota.agregarVehiculo(c2);
        gestorFlota.agregarVehiculo(f1);
        gestorFlota.agregarVehiculo(f2);

        // Imprimir los detalles de la flota
        gestorFlota.imprimirDetallesFlota();

        // Calcular y mostrar el consumo total de la flota
        double distanciaRecorrida = 500.0;
        double litrosConsumidos = 50.0;
        double consumoTotalFlota = gestorFlota.calcularConsumoTotalFlota(distanciaRecorrida, litrosConsumidos);
        System.out.println("Consumo total de la flota: " + consumoTotalFlota + " litros/km");

        // Filtrar y mostrar los camiones que pueden transportar "Carga pesada"
        ArrayList<Camion> camionesCargarPesada = gestorFlota.filtrarVehiculosPorTipoCarga("Carga pesada");
        System.out.println("Camiones que pueden transportar Carga pesada:");
        for (Camion camion : camionesCargarPesada) {
            System.out.println("Marca: " + camion.marca + ", Modelo: " + camion.modelo);
        }

        // Filtrar y mostrar las furgonetas que pueden transportar al menos 5 pasajeros
        ArrayList<Furgoneta> furgonetasCapacidadMinima = gestorFlota.filtrarVehiculosPorCapacidadPasajeros(5);
        System.out.println("Furgonetas que pueden transportar al menos 5 pasajeros:");
        for (Furgoneta furgoneta : furgonetasCapacidadMinima) {
            System.out.println("Marca: " + furgoneta.marca + ", Modelo: " + furgoneta.modelo);
        }
    }
}