using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasOrdenadores.Modelo
{
    public class Gamer : Ordenador
    {
        public Gamer(int precio, int ram, int almacenamiento) : base(precio, ram, almacenamiento) { }
    }
}