namespace FigurasNET.Vehiculos.Ruedas;

public class RuedaNormal : IRueda
{
    private readonly double precio;
    private readonly string tipoGoma;

    public RuedaNormal(string tipoGoma, double precio)
    {
        this.tipoGoma = tipoGoma;
        this.precio = precio;
    }

    public double dameCoste()
    {
        return precio;
    }

    public string dameGoma()
    {
        return tipoGoma;
    }
}