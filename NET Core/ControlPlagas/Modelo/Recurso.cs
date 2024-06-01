using ControlPlagas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Modelo
{
    public class Recurso : IRecurso
    {
        public string Nombre { get; set; }
        public decimal CostoServicio { get; set; }
    }
}
