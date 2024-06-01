namespace SistemaDefensa.Modelo;

public class TransporteRapido : IUnidadMilitar
{
    public TransporteRapido()
    {
        Velocidad = new VelocidadAlta(12);
    }

    public string Nombre { get; set; } = "TAXIN-66";
    public IVelocidad Velocidad { get; set; }
    public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
    public IPotenciaFuego PotenciaFuego { get; set; } = new PotenciaFuegoNula();
    public double Precio { get; set; } = 1600;
}