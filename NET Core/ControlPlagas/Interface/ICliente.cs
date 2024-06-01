using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Interface
{
    public interface ICliente
    {
        string NombreCompleto { get; set; }
        string Telefono { get; set; }
        string Email { get; set; }
        string CodigoPostal { get; set; }
    }
}
