namespace Discografica.Modelo;

public class Coleccion02
{
    private readonly List<Anuncio> anuncios;
    private readonly List<ICancion> canciones;
    private readonly IValidador validador;

    public Coleccion02(IValidador validador)
    {
        canciones = new List<ICancion>();
        anuncios = new List<Anuncio>();
        this.validador = validador;
    }

    public void AgregarCancion(ICancion cancion)
    {
        if (validador.EsValida(cancion as Cancion)) canciones.Add(cancion);
    }

    public void AgregarAnuncio(Anuncio anuncio)
    {
        anuncios.Add(anuncio);
    }

    public double ObtenerDuracionTotal()
    {
        double duracionTotal = 0;
        foreach (var cancion in canciones) duracionTotal += cancion.Duracion;
        return duracionTotal;
    }

    public int ObtenerCantidadCanciones()
    {
        return canciones.Count;
    }

    public double ObtenerIngresos()
    {
        double ingresos = 0;
        foreach (var anuncio in anuncios) ingresos += anuncio.Costo;
        return ingresos;
    }
}