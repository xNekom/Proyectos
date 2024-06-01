namespace SistemaDefensa.Modelo;

public class TorpedoMovil : IUnidadMilitar
{
    public TorpedoMovil()
    {
        Velocidad = new VelocidadBaja(3);
        Blindaje = new BlindajeBajo(2);
        PotenciaFuego = new PotenciaFuegoAlta(19);
    }

    public string Nombre { get; set; } = "Torpedero móvil";
    public IVelocidad Velocidad { get; set; }
    public IBlindaje Blindaje { get; set; }
    public IPotenciaFuego PotenciaFuego { get; set; }
    public double Precio { get; set; } = 1350;
}