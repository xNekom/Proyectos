using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica.Modelo
{
    public class FabricaValidador
    {
        public static IValidador CrearValidador(string tipo)
        {
            if (tipo == "inicial")
            {
                return new ValidadorInicial();
            }
            else if (tipo == "corea")
            {
                return new ValidadorCorea();
            }
            else
            {
                throw new ArgumentException("Tipo de validador no válido");
            }
        }
    }

}
