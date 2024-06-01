// Clase Camion
class Camion extends VehiculoTransporte {
    private String tipoCarga;

    public Camion(String marca, String modelo, int anioFabricacion, int capacidadCarga, int velocidadMaxima, String tipoCarga) {
        this.marca = marca;
        this.modelo = modelo;
        this.anioFabricacion = anioFabricacion;
        this.capacidadCarga = capacidadCarga;
        this.velocidadMaxima = velocidadMaxima;
        this.tipoCarga = tipoCarga;
    }

    @Override
    public double calcularConsumoPromedio(double distanciaRecorrida, double litrosConsumidos) {
        return litrosConsumidos / distanciaRecorrida;
    }

    public String getTipoCarga() {
        return tipoCarga;
    }
}