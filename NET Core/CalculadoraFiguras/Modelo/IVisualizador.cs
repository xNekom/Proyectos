using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFiguras.Modelo
{
    public interface IVisualizador
    {
        void DibujarFigura(IMedible figura);
    }
}