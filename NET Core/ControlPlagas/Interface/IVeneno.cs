using ControlPlagas.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Interface
{
    public interface IVeneno
    {
        string Nombre { get; set; }
        UnidadMedida UnidadMedida { get; set; }
        decimal CostoUnidad { get; set; }
        decimal Cantidad { get; set; }
    }
}
