namespace SistemaDefensa.Modelo;

public class VelocidadBaja : IVelocidad
{
    public VelocidadBaja(double velocidad)
    {
        Velocidad = velocidad;
    }

    public double Velocidad { get; set; }
}