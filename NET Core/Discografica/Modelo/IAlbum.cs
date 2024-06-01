namespace Discografica.Modelo;

public interface IAlbum
{
    List<ICancion> Canciones { get; }
    void AgregarCancion(ICancion cancion);
}