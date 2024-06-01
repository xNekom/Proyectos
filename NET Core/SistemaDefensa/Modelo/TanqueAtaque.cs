namespace SistemaDefensa.Modelo;

public class TanqueAtaque : IUnidadMilitar
{
    public TanqueAtaque()
    {
        Velocidad = new VelocidadMedia(7.3);
        Blindaje = new BlindajeAlto(4.8);
        PotenciaFuego = new PotenciaFuegoAlta(9.8);
    }

    public string Nombre { get; set; } = "Sombras-VB98";
    public IVelocidad Velocidad { get; set; }
    public IBlindaje Blindaje { get; set; }
    public IPotenciaFuego PotenciaFuego { get; set; }
    public double Precio { get; set; } = 15600;
}