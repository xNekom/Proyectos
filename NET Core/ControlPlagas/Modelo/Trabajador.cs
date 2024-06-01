using ControlPlagas.Enum;
using ControlPlagas.Interface;

namespace ControlPlagas.Modelo;

public class Trabajador : ITrabajador
{
    public string Nombre { get; set; }
    public decimal Ingreso { get; set; }
    public TipoTrabajador Tipo { get; set; }
}