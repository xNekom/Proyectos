using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasOrdenadores.Modelo
{
    public class Lentorro : Ordenador
    {
        public Lentorro(int precio, int ram, int almacenamiento) : base(precio, ram, almacenamiento) { }
    }
}