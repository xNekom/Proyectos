using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class VelocidadMedia : IVelocidad
    {
        public double Velocidad { get; set; }

        public VelocidadMedia(double velocidad)
        {
            Velocidad = velocidad;
        }
    }
}
