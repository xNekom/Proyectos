﻿namespace Discografica.Modelo;

public class FabricaAlbum
{
    public static IAlbum CrearAlbum(string titulo)
    {
        return new Album(titulo);
    }

    public static ICancion CrearCancion(string titulo, double duracion, string distribucion)
    {
        return new Cancion { Titulo = titulo, Duracion = duracion, ListaDistribucion = distribucion };
    }
}