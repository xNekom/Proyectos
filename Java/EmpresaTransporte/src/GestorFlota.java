import java.util.ArrayList;

class GestorFlota {
    private ArrayList<VehiculoTransporte> flota;

    public GestorFlota() {
        this.flota = new ArrayList<>();
    }

    public void agregarVehiculo(VehiculoTransporte vehiculo) {
        flota.add(vehiculo);
    }

    public void eliminarVehiculo(VehiculoTransporte vehiculo) {
        flota.remove(vehiculo);
    }

    public void imprimirDetallesFlota() {
        for (VehiculoTransporte vehiculo : flota) {
            System.out.println("Marca: " + vehiculo.marca);
            System.out.println("Modelo: " + vehiculo.modelo);
            System.out.println("Año de fabricación: " + vehiculo.anioFabricacion);
            System.out.println("Capacidad de carga: " + vehiculo.capacidadCarga + " kg");
            System.out.println("Velocidad máxima: " + vehiculo.velocidadMaxima + " km/h");
            if (vehiculo instanceof Camion) {
                System.out.println("Tipo de carga: " + ((Camion) vehiculo).getTipoCarga());
            } else if (vehiculo instanceof Furgoneta) {
                System.out.println("Capacidad de pasajeros: " + ((Furgoneta) vehiculo).getCapacidadPasajeros());
            }
            System.out.println();
        }
    }

    public double calcularConsumoTotalFlota(double distanciaRecorrida, double litrosConsumidos) {
        double consumoTotal = 0;
        for (VehiculoTransporte vehiculo : flota) {
            consumoTotal += vehiculo.calcularConsumoPromedio(distanciaRecorrida, litrosConsumidos);
        }
        return consumoTotal;
    }

    public ArrayList<Camion> filtrarVehiculosPorTipoCarga(String tipoCarga) {
        ArrayList<Camion> camionesFiltrados = new ArrayList<>();
        for (VehiculoTransporte vehiculo : flota) {
            if (vehiculo instanceof Camion && ((Camion) vehiculo).getTipoCarga().equals(tipoCarga)) {
                camionesFiltrados.add((Camion) vehiculo);
            }
        }
        return camionesFiltrados;
    }

    public ArrayList<Furgoneta> filtrarVehiculosPorCapacidadPasajeros(int capacidadMinima) {
        ArrayList<Furgoneta> furgonetasFiltradas = new ArrayList<>();
        for (VehiculoTransporte vehiculo : flota) {
            if (vehiculo instanceof Furgoneta && ((Furgoneta) vehiculo).getCapacidadPasajeros() >= capacidadMinima) {
                furgonetasFiltradas.add((Furgoneta) vehiculo);
            }
        }
        return furgonetasFiltradas;
    }
}