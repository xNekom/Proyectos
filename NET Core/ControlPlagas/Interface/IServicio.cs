namespace ControlPlagas.Interface;

public interface IServicio
{
    ICliente Cliente { get; set; }
    IEquipo Equipo { get; set; }
    List<IVeneno> Venenos { get; set; }
    decimal Ingreso { get; set; }
    decimal Gasto { get; set; }
}