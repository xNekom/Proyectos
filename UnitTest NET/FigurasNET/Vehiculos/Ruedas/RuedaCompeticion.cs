namespace FigurasNET.Vehiculos.Ruedas;

public class RuedaCompeticion : IRueda
{
    public RuedaCompeticion(double porcentaje)
    {
        Porcentaje = porcentaje;
    }

    public double Porcentaje { get; set; }

    public double dameCoste()
    {
        return 22 * Porcentaje;
    }

    public string dameGoma()
    {
        return "competicion";
    }
}