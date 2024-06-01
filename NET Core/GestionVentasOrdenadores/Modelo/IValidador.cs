using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentasOrdenadores.Modelo
{
    // Interfaz IValidador
    public interface IValidador
    {
        bool EsValido(int precio, int tiempoGarantia);
    }
}