namespace Discografica.Modelo;

public class ValidadorCorea : IValidador
{
    public bool EsValida(Cancion cancion)
    {
        return cancion.Duracion >= 7 && cancion.Duracion <= 15;
    }
}