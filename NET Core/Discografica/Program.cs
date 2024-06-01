/*
Tenemos una discográfica que nos permite crear listas de reproducción.
Cada disco estará compuesto de canciones. Cada canción tendrá su duración y la lista de distribución. Inicialmente, las canciones no podrán superar los 10 minutos de duración.
Queremos saber la duración total y el número de canciones de una lista de distribución.
Ahora, la discográfica se ha trasladado a Corea y tenemos otro negocio similar. En este nuevo negocio, se utilizará un nuevo validador que considerará válidas las canciones con una duración entre 7 y 15 minutos. Crea este nuevo Validador y emula estas nuevas condiciones.
Además, vamos a tener elementos de reproducción con un canon, es decir, nos van a pagar por incluirlos en nuestra lista de distribución. Esta nueva Clase Anuncio tendrá un costo para nuestros clientes.
Queremos crear una colección, un nuevo wrapper denominado Coleccion02, que nos permita conocer la cantidad de elementos de reproducción, su duración total y el dinero que vamos a recibir por cada lista de distribución.
*/

using Discografica.Modelo;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Coleccion02 coleccion = new Coleccion02(new ValidadorInicial());
        ICancion cancion1 = FabricaAlbum.CrearCancion("Canción 1", 8, "Distribución 1");
        ICancion cancion2 = FabricaAlbum.CrearCancion("Canción 2", 6, "Distribución 2");
        ICancion cancion3 = FabricaAlbum.CrearCancion("Canción 3", 12, "Distribución 3");
        coleccion.AgregarCancion(cancion1);
        coleccion.AgregarCancion(cancion2);
        coleccion.AgregarCancion(cancion3);

        Console.WriteLine($"Duración total: {coleccion.ObtenerDuracionTotal()} minutos");
        Console.WriteLine($"Cantidad de canciones: {coleccion.ObtenerCantidadCanciones()}");

        Coleccion02 coleccionCorea = new Coleccion02(new ValidadorCorea());
        ICancion cancionCorea1 = FabricaAlbum.CrearCancion("Canción Corea 1", 10, "Distribución Corea 1");
        ICancion cancionCorea2 = FabricaAlbum.CrearCancion("Canción Corea 2", 8, "Distribución Corea 2");
        ICancion cancionCorea3 = FabricaAlbum.CrearCancion("Canción Corea 3", 14, "Distribución Corea 3");
        coleccionCorea.AgregarCancion(cancionCorea1);
        coleccionCorea.AgregarCancion(cancionCorea2);
        coleccionCorea.AgregarCancion(cancionCorea3);

        Console.WriteLine($"Duración total (Corea): {coleccionCorea.ObtenerDuracionTotal()} minutos");
        Console.WriteLine($"Cantidad de canciones (Corea): {coleccionCorea.ObtenerCantidadCanciones()}");

        Anuncio anuncio1 = new Anuncio { Costo = 100 };
        Anuncio anuncio2 = new Anuncio { Costo = 150 };
        coleccionCorea.AgregarAnuncio(anuncio1);
        coleccionCorea.AgregarAnuncio(anuncio2);

        Console.WriteLine($"Ingresos (Corea): {coleccionCorea.ObtenerIngresos()} euros");
    }
}