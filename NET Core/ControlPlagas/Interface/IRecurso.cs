using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Interface
{
    public interface IRecurso
    {
        string Nombre { get; set; }
        decimal CostoServicio { get; set; }
    }
}
