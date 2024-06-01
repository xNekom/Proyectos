using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFiguras.Modelo
{
    // Clase Círculo
    public class Circulo : IMedible
    {
        private int radio;

        public Circulo(int radio)
        {
            this.radio = radio;
        }

        public double dameSuperficie()
        {
            return Math.PI * radio * radio;
        }

        public double damePerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}