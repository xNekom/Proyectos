using ControlPlagas.Interface;

namespace ControlPlagas.Modelo;

public class Equipo : IEquipo
{
    public ITrabajador JefeEquipo { get; set; }
    public List<ITrabajador> Peones { get; set; }
    public decimal Gasto { get; set; }
}