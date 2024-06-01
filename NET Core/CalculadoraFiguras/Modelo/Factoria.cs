using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFiguras.Modelo
{
    // Clase Factoría
    public class Factoria : IFactoriaMedibles
    {
        public IMedible dameFigura(TipoFigura tipo, int valor)
        {
            switch (tipo)
            {
                case TipoFigura.Cuadrado:
                    return new Cuadrado(valor);
                case TipoFigura.Circulo:
                    return new Circulo(valor);
                default:
                    throw new ArgumentException("Tipo de figura no válido.");
            }
        }
    }
}