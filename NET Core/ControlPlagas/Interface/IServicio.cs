using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Interface
{
    public interface IServicio
    {
        ICliente Cliente { get; set; }
        IEquipo Equipo { get; set; }
        List<IVeneno> Venenos { get; set; }
        decimal Ingreso { get; set; }
        decimal Gasto { get; set; }
    }
}
