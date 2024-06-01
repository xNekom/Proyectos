namespace SistemaDefensa.Modelo;

public class BlindajeBajo : IBlindaje
{
    public BlindajeBajo(double blindaje)
    {
        Blindaje = blindaje;
    }

    public double Blindaje { get; set; }
}