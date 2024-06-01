using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica.Modelo
{
    public interface IValidador
    {
        bool EsValida(Cancion cancion);
    }
}
