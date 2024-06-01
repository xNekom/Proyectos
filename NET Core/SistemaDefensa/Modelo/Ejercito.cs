namespace SistemaDefensa.Modelo;

public class Ejercito : IEjercito
{
    private double fondoDisponible;
    private readonly List<IUnidadMilitar> unidades;

    public Ejercito(double fondoDisponible)
    {
        unidades = new List<IUnidadMilitar>();
        this.fondoDisponible = fondoDisponible;
    }

    public void AgregarUnidad(IUnidadMilitar unidad)
    {
        if (unidad.Precio <= fondoDisponible)
        {
            unidades.Add(unidad);
            fondoDisponible -= unidad.Precio;
        }
        else
        {
            throw new Exception("No hay suficiente presupuesto para agregar esta unidad.");
        }
    }

    public int CantidadUnidades()
    {
        return unidades.Count;
    }

    public double PotenciaFuegoTotal()
    {
        return unidades.Sum(u => u.PotenciaFuego.PotenciaFuego);
    }

    public double BlindajeTotal()
    {
        return unidades.Sum(u => u.Blindaje.Blindaje);
    }

    public double CapacidadMovimiento()
    {
        return unidades.Sum(u => u.Velocidad.Velocidad);
    }

    public double DineroGastado()
    {
        return fondoDisponible;
    }

    public double CapacidadMilitar()
    {
        var potenciaFuego = PotenciaFuegoTotal();
        var capacidadMovimiento = CapacidadMovimiento();
        var blindaje = BlindajeTotal();
        return potenciaFuego * capacidadMovimiento / (2 * (100 - blindaje));
    }
}