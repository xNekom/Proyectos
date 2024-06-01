namespace Discografica.Modelo;

public class Cancion : ICancion
{
    public string Titulo { get; set; }
    public double Duracion { get; set; }
    public string ListaDistribucion { get; set; }
}