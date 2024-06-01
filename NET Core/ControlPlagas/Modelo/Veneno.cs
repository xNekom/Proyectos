using ControlPlagas.Enum;
using ControlPlagas.Interface;

namespace ControlPlagas.Modelo;

public class Veneno : IVeneno
{
    public string Nombre { get; set; }
    public UnidadMedida UnidadMedida { get; set; }
    public decimal CostoUnidad { get; set; }
    public decimal Cantidad { get; set; }
}