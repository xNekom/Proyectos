using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasOrdenadores.Modelo
{
    public class Normal : Ordenador
    {
        public Normal(int precio, int ram, int almacenamiento) : base(precio, ram, almacenamiento) { }
    }
}