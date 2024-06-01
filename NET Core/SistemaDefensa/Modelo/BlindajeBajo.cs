using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class BlindajeBajo : IBlindaje
    {
        public double Blindaje { get; set; }

        public BlindajeBajo(double blindaje)
        {
            Blindaje = blindaje;
        }
    }
}
