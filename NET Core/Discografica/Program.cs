using Discografica.Modelo;

public class Program
{
    private static void Main(string[] args)
    {
        var coleccion = new Coleccion02(new ValidadorInicial());
        var cancion1 = FabricaAlbum.CrearCancion("Canción 1", 8, "Distribución 1");
        var cancion2 = FabricaAlbum.CrearCancion("Canción 2", 6, "Distribución 2");
        var cancion3 = FabricaAlbum.CrearCancion("Canción 3", 12, "Distribución 3");
        coleccion.AgregarCancion(cancion1);
        coleccion.AgregarCancion(cancion2);
        coleccion.AgregarCancion(cancion3);

        Console.WriteLine($"Duración total: {coleccion.ObtenerDuracionTotal()} minutos");
        Console.WriteLine($"Cantidad de canciones: {coleccion.ObtenerCantidadCanciones()}");

        var coleccionCorea = new Coleccion02(new ValidadorCorea());
        var cancionCorea1 = FabricaAlbum.CrearCancion("Canción Corea 1", 10, "Distribución Corea 1");
        var cancionCorea2 = FabricaAlbum.CrearCancion("Canción Corea 2", 8, "Distribución Corea 2");
        var cancionCorea3 = FabricaAlbum.CrearCancion("Canción Corea 3", 14, "Distribución Corea 3");
        coleccionCorea.AgregarCancion(cancionCorea1);
        coleccionCorea.AgregarCancion(cancionCorea2);
        coleccionCorea.AgregarCancion(cancionCorea3);

        Console.WriteLine($"Duración total (Corea): {coleccionCorea.ObtenerDuracionTotal()} minutos");
        Console.WriteLine($"Cantidad de canciones (Corea): {coleccionCorea.ObtenerCantidadCanciones()}");

        var anuncio1 = new Anuncio { Costo = 100 };
        var anuncio2 = new Anuncio { Costo = 150 };
        coleccionCorea.AgregarAnuncio(anuncio1);
        coleccionCorea.AgregarAnuncio(anuncio2);

        Console.WriteLine($"Ingresos (Corea): {coleccionCorea.ObtenerIngresos()} euros");
    }
}