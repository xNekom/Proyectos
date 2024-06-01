using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasOrdenadores.Modelo
{
    public class Tienda
    {
        private List<Ordenador> ordenadores;

        public Tienda()
        {
            ordenadores = new List<Ordenador>();
        }

        public void AgregarOrdenador(Ordenador ordenador)
        {
            ordenadores.Add(ordenador);
        }

        public double TotalFacturado()
        {
            return ordenadores.Sum(o => o.precio);
        }

        public int NumeroOrdenadoresVendidos()
        {
            return ordenadores.Count;
        }

        public Ordenador OrdenadorMasBarato()
        {
            return ordenadores.OrderBy(o => o.precio).FirstOrDefault();
        }

        public Ordenador OrdenadorMasCaro()
        {
            return ordenadores.OrderByDescending(o => o.precio).FirstOrDefault();
        }

        public double PrecioMedio()
        {
            return ordenadores.Average(o => o.precio);
        }

        public int NumeroOrdenadoresMayores125()
        {
            return ordenadores.Count(o => o.precio > 125);
        }

        public void Listado()
        {
            foreach (var ordenador in ordenadores)
            {
                Console.WriteLine(ordenador);
            }
        }
    }
}