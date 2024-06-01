namespace SistemaDefensa.Modelo;

public class InfanteriaBasica : IUnidadMilitar
{
    public InfanteriaBasica()
    {
        Velocidad = new VelocidadMedia(6);
        PotenciaFuego = new PotenciaFuegoBaja(7);
    }

    public string Nombre { get; set; } = "Infantería Básica";
    public IVelocidad Velocidad { get; set; }
    public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
    public IPotenciaFuego PotenciaFuego { get; set; }
    public double Precio { get; set; } = 250;
}