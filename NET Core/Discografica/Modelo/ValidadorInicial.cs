using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica.Modelo
{
    public class ValidadorInicial : IValidador
    {
        public bool EsValida(Cancion cancion)
        {
            return cancion.Duracion <= 10;
        }
    }
}
