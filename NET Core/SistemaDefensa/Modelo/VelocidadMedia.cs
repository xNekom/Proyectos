namespace SistemaDefensa.Modelo;

public class VelocidadMedia : IVelocidad
{
    public VelocidadMedia(double velocidad)
    {
        Velocidad = velocidad;
    }

    public double Velocidad { get; set; }
}