using ControlPlagas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Modelo
{
    public class Cliente : ICliente
    {
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string CodigoPostal { get; set; }
    }
}
