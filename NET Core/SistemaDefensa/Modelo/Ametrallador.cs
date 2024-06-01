namespace SistemaDefensa.Modelo;

public class Ametrallador : IUnidadMilitar
{
    public Ametrallador()
    {
        Velocidad = new VelocidadMedia(4);
        PotenciaFuego = new PotenciaFuegoAlta(10);
    }

    public string Nombre { get; set; } = "Ametrallador";
    public IVelocidad Velocidad { get; set; }
    public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
    public IPotenciaFuego PotenciaFuego { get; set; }
    public double Precio { get; set; } = 400;
}