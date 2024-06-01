namespace SistemaDefensa.Modelo;

public class PotenciaFuegoAlta : IPotenciaFuego
{
    public PotenciaFuegoAlta(double potenciaFuego)
    {
        PotenciaFuego = potenciaFuego;
    }

    public double PotenciaFuego { get; set; }
}