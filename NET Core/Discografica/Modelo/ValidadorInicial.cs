namespace Discografica.Modelo;

public class ValidadorInicial : IValidador
{
    public bool EsValida(Cancion cancion)
    {
        return cancion.Duracion <= 10;
    }
}