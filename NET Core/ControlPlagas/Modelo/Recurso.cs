using ControlPlagas.Interface;

namespace ControlPlagas.Modelo;

public class Recurso : IRecurso
{
    public string Nombre { get; set; }
    public decimal CostoServicio { get; set; }
}