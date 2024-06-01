using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class VelocidadBaja : IVelocidad
    {
        public double Velocidad { get; set; }

        public VelocidadBaja(double velocidad)
        {
            Velocidad = velocidad;
        }
    }
}
