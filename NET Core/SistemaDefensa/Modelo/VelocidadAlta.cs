using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class VelocidadAlta : IVelocidad
    {
        public double Velocidad { get; set; }

        public VelocidadAlta(double velocidad)
        {
            Velocidad = velocidad;
        }
    }
}
