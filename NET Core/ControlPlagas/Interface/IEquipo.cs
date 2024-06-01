namespace ControlPlagas.Interface;

public interface IEquipo
{
    ITrabajador JefeEquipo { get; set; }
    List<ITrabajador> Peones { get; set; }
    decimal Gasto { get; set; }
}