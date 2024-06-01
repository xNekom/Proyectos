namespace SistemaDefensa.Modelo;

public class BlindajeAlto : IBlindaje
{
    public BlindajeAlto(double blindaje)
    {
        Blindaje = blindaje;
    }

    public double Blindaje { get; set; }
}