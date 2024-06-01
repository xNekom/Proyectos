using ControlPlagas.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Interface
{
    public interface ITrabajador
    {
        string Nombre { get; set; }
        decimal Ingreso { get; set; }
        TipoTrabajador Tipo { get; set; }
    }
}
