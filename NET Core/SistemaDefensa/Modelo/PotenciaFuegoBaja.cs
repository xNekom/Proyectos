namespace SistemaDefensa.Modelo;

public class PotenciaFuegoBaja : IPotenciaFuego
{
    public PotenciaFuegoBaja(double potenciaFuego)
    {
        PotenciaFuego = potenciaFuego;
    }

    public double PotenciaFuego { get; set; }
}