using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Interface
{
    public interface IEquipo
    {
        ITrabajador JefeEquipo { get; set; }
        List<ITrabajador> Peones { get; set; }
        decimal Gasto { get; set; }
    }
}
