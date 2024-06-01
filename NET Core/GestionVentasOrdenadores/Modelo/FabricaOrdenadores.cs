using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasOrdenadores.Modelo
{
    public class FabricaOrdenadores
    {
        private IValidador validador;

        public FabricaOrdenadores(IValidador validador)
        {
            this.validador = validador;
        }

        public Ordenador CrearOrdenador(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return new Lentorro(100, 4, 250);
                case 2:
                    return new Normal(300, 8, 500);
                case 3:
                    return new Gamer(1000, 16, 1000);
                default:
                    return null;
            }
        }

        public Ordenador CrearOrdenador(int tipo, int precio, int ram, int almacenamiento)
        {
            if (!validador.EsValido(precio, 0)) // Aquí se asume que el tiempo de garantía no es relevante
                return null;

            switch (tipo)
            {
                case 1:
                    return new Lentorro(precio, ram, almacenamiento);
                case 2:
                    return new Normal(precio, ram, almacenamiento);
                case 3:
                    return new Gamer(precio, ram, almacenamiento);
                default:
                    return null;
            }
        }
    }
}