using ControlPlagas.Enum;
using ControlPlagas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Modelo
{
    public class Trabajador : ITrabajador
    {
        public string Nombre { get; set; }
        public decimal Ingreso { get; set; }
        public TipoTrabajador Tipo { get; set; }
    }
}
