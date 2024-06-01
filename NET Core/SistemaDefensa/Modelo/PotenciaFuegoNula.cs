using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class PotenciaFuegoNula : IPotenciaFuego
    {
        public double PotenciaFuego { get; set; } = 0;
    }
}
