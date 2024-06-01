using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class BlindajeAlto : IBlindaje
    {
        public double Blindaje { get; set; }

        public BlindajeAlto(double blindaje)
        {
            Blindaje = blindaje;
        }
    }
}
