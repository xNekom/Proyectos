using ControlPlagas.Interface;

namespace ControlPlagas.Modelo;

public class Cliente : ICliente
{
    public string NombreCompleto { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string CodigoPostal { get; set; }
}