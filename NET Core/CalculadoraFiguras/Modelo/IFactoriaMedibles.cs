using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFiguras.Modelo
{
    // Interfaz IFactoriaMedibles
    public interface IFactoriaMedibles
    {
        IMedible dameFigura(TipoFigura tipo, int valor);
    }
}