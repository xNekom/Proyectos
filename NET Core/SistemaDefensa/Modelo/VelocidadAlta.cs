namespace SistemaDefensa.Modelo;

public class VelocidadAlta : IVelocidad
{
    public VelocidadAlta(double velocidad)
    {
        Velocidad = velocidad;
    }

    public double Velocidad { get; set; }
}