using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFiguras.Modelo
{
    // Clase Tablero de Figuras
    public class TableroFiguras
    {
        private List<IMedible> figuras;
        private IVisualizador visualizador;

        public TableroFiguras(IVisualizador visualizador = null)
        {
            figuras = new List<IMedible>();
            this.visualizador = visualizador;
        }

        public void AgregarFigura(IMedible figura)
        {
            figuras.Add(figura);
            visualizador?.DibujarFigura(figura);
        }

        public double SuperficieTotal()
        {
            return figuras.Sum(f => f.dameSuperficie());
        }

        public double PerimetroTotal()
        {
            return figuras.Sum(f => f.damePerimetro());
        }

        public IMedible FiguraMasGrande()
        {
            return figuras.OrderByDescending(f => f.dameSuperficie()).FirstOrDefault();
        }

        public IMedible FiguraMasPequena()
        {
            return figuras.OrderBy(f => f.dameSuperficie()).FirstOrDefault();
        }

        public double SuperficiePromedio()
        {
            return figuras.Average(f => f.dameSuperficie());
        }

        public double PerimetroPromedio()
        {
            return figuras.Average(f => f.damePerimetro());
        }
    }
}