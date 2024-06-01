using ControlPlagas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Modelo
{
    public class Equipo : IEquipo
    {
        public ITrabajador JefeEquipo { get; set; }
        public List<ITrabajador> Peones { get; set; }
        public decimal Gasto { get; set; }
    }
}
