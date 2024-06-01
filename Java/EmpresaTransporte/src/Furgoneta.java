class Furgoneta extends VehiculoTransporte {
    private int capacidadPasajeros;

    public Furgoneta(String marca, String modelo, int anioFabricacion, int capacidadCarga, int velocidadMaxima, int capacidadPasajeros) {
        this.marca = marca;
        this.modelo = modelo;
        this.anioFabricacion = anioFabricacion;
        this.capacidadCarga = capacidadCarga;
        this.velocidadMaxima = velocidadMaxima;
        this.capacidadPasajeros = capacidadPasajeros;
    }

    @Override
    public double calcularConsumoPromedio(double distanciaRecorrida, double litrosConsumidos) {
        return litrosConsumidos / distanciaRecorrida;
    }

    public int getCapacidadPasajeros() {
        return capacidadPasajeros;
    }
}