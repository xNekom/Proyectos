namespace Discografica.Modelo;

public class Album : IAlbum
{
    public Album(string titulo)
    {
        Canciones = new List<ICancion>();
    }

    public void AgregarCancion(ICancion cancion)
    {
        Canciones.Add(cancion);
    }

    public List<ICancion> Canciones { get; }
}