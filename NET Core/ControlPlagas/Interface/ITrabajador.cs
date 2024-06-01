using ControlPlagas.Enum;

namespace ControlPlagas.Interface;

public interface ITrabajador
{
    string Nombre { get; set; }
    decimal Ingreso { get; set; }
    TipoTrabajador Tipo { get; set; }
}