abstract class VehiculoTransporte {
    protected String marca;
    protected String modelo;
    protected int anioFabricacion;
    protected int capacidadCarga; // en kg
    protected int velocidadMaxima; // en km/h

    public abstract double calcularConsumoPromedio(double distanciaRecorrida, double litrosConsumidos);
}