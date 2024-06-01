using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class PotenciaFuegoBaja : IPotenciaFuego
    {
        public double PotenciaFuego { get; set; }

        public PotenciaFuegoBaja(double potenciaFuego)
        {
            PotenciaFuego = potenciaFuego;
        }
    }
}
