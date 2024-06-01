using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica.Modelo
{
    public interface ICancion
    {
        string Titulo { get; }
        double Duracion { get; }
        string ListaDistribucion { get; }

    }
}
