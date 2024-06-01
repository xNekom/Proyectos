using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class VelocidadNula : IVelocidad
    {
        public double Velocidad { get; set; } = 0;
    }
}
