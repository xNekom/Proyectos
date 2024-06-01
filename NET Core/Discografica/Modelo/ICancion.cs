namespace Discografica.Modelo;

public interface ICancion
{
    string Titulo { get; }
    double Duracion { get; }
    string ListaDistribucion { get; }
}