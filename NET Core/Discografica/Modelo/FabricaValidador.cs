namespace Discografica.Modelo;

public class FabricaValidador
{
    public static IValidador CrearValidador(string tipo)
    {
        if (tipo == "inicial")
            return new ValidadorInicial();
        if (tipo == "corea")
            return new ValidadorCorea();
        throw new ArgumentException("Tipo de validador no válido");
    }
}