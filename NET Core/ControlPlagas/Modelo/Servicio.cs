using ControlPlagas.Interface;

namespace ControlPlagas.Modelo;

public class Servicio : IServicio
{
    public ICliente Cliente { get; set; }
    public IEquipo Equipo { get; set; }
    public List<IVeneno> Venenos { get; set; }
    public decimal Ingreso { get; set; }
    public decimal Gasto { get; set; }
}