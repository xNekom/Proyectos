using ControlPlagas.Enum;

namespace ControlPlagas.Interface;

public interface IVeneno
{
    string Nombre { get; set; }
    UnidadMedida UnidadMedida { get; set; }
    decimal CostoUnidad { get; set; }
    decimal Cantidad { get; set; }
}