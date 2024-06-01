using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica.Modelo
{
    public class Cancion : ICancion
    {
        public string Titulo { get; set; }
        public double Duracion { get; set; }
        public string ListaDistribucion { get; set; }
    }
}