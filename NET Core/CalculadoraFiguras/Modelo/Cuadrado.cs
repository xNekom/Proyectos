using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFiguras.Modelo
{
    // Clase Cuadrado
    public class Cuadrado : IMedible
    {
        private int lado;

        public Cuadrado(int lado)
        {
            this.lado = lado;
        }

        public double dameSuperficie()
        {
            return lado * lado;
        }

        public double damePerimetro()
        {
            return 4 * lado;
        }
    }
}