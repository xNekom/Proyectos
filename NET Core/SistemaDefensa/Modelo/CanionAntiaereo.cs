namespace SistemaDefensa.Modelo;

public class CanionAntiaereo : IUnidadMilitar
{
    public CanionAntiaereo()
    {
        PotenciaFuego = new PotenciaFuegoAlta(22);
    }

    public string Nombre { get; set; } = "Cañon Antiaéreo";
    public IVelocidad Velocidad { get; set; } = new VelocidadBaja(1);
    public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
    public IPotenciaFuego PotenciaFuego { get; set; }
    public double Precio { get; set; } = 1100;
}