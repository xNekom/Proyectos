namespace SistemaDefensa.Modelo;

public class Transporte : IUnidadMilitar
{
    public Transporte()
    {
        Velocidad = new VelocidadMedia(4.5);
        Blindaje = new BlindajeBajo(1.4);
    }

    public string Nombre { get; set; } = "MX-7899";
    public IVelocidad Velocidad { get; set; }
    public IBlindaje Blindaje { get; set; }
    public IPotenciaFuego PotenciaFuego { get; set; } = new PotenciaFuegoNula();
    public double Precio { get; set; } = 4200;
}